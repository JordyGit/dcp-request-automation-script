using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skyline.DataMiner.MessageBroker;
using Skyline.DataMiner.MessageBroker.ProtoHelpers;
using Skyline.Dataminer.Proto.CcaGatewayTypes;
using Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses;

namespace SLChatIntegrationHelper
{
    public static class Helper
    {
        /// <remarks>Don't forget to dispose the <paramref name="broker"/> after use!</remarks>
        public static bool TryConnectToMessageBroker(Action<string> log, out ISLMessageBroker broker)
        {
            // Connect to NATS
            log("Connecting to the message broker...");

            //SLMessageBrokerFactorySingleton.XmlPath = "C:\\Skyline DataMiner\\SLCloud.xml"; is already the default value

            broker = SLMessageBrokerFactorySingleton.Instance.Create();

            int i;
            for (i = 0; i < 3 && broker == null; i++)
            {
                broker = SLMessageBrokerFactorySingleton.Instance.Create();

                if (broker != null)
                {
                    break;
                }

                log($"Failed to connect to the message broker, retrying later... ({i + 1})");

                Task.Delay(2000).Wait();
            }

            if (broker == null)
            {
                log($"Couldn't connect to the message broker within {i + 1} retries.");
                return false;
            }

            log("Connected to the message broker.");
            return true;
        }

        public static bool TryFetchDmsAccessToken(Action<string> log, ISLMessageBroker broker, out string accessToken)
        {
            // Fetch dms authentication token from CloudGateway using NATS
            log("Fetching DMS Authentication token...");
            accessToken = null;
            var tokenResponse = broker.ProtoReqReply(new GetCloudAccessTokenRequest()
            {
                Scopes = "6091cf86-293d-40ae-ba35-8378f60db93e/.default"
            }, GetCloudAccessTokenResponse.Parser);

            if (tokenResponse.Error != null && tokenResponse.Error.ContainsError)
            {
                log($"Couldn't fetch DMS Authentication token because of {string.Join(";", tokenResponse.Error.Errors.Select(e => $"{e.Type}: {e.Message}"))}.");
                return false;
            }

            if (tokenResponse.ExpirationDate.ToDateTimeOffset() <= DateTimeOffset.UtcNow)
            {
                log("Received an expired DMS Authentication token.");
                return false;
            }

            log("Fetched DMS Authentication token.");
            accessToken = tokenResponse.AccessToken;
            return true;
        }

        public static bool TrySendDcpRequest(Action<string> log, ISLMessageBroker broker, HttpMethod httpMethod, string path, string token, JObject body, int timeout, out DcpResponse response)
        {
            // Send request over NATS (via CloudGateway DxM to the cloud)
            log("Sending request to DCP...");

            var protoResponse = broker.ProtoReqReply(new DcpRequestResponseRequest()
            {
                DcpRequest = new DcpRequest()
                {
                    Token = token,
                    Path = path,
                    HttpMethod = httpMethod.ToString(),
                    JsonBody = JsonConvert.SerializeObject(body)
                }
            }, DcpRequestResponseResponse.Parser, timeout);

            if (protoResponse.ContainsError)
            {
                log($"Couldn't send the request to DCP because of {protoResponse.Error}.");
                response = null;
                return false;
            }

            log("Sent request to DCP.");
            response = protoResponse.DcpResponse;
            return true;
        }
    }
}