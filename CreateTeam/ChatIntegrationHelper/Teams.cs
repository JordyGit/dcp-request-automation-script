using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skyline.DataMiner.MessageBroker;
using Skyline.DataMiner.MessageBroker.ProtoHelpers;
using Skyline.Dataminer.Proto.CcaGatewayTypes;
using Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses;

namespace ChatIntegrationHelper
{
    public class Teams : ITeamsChatIntegrationHelper
    {
        public void CreateTeam(string teamName, string ownerEmail, string[] memberEmails)
        {
            if (!TryConnectToMessageBroker(out var broker))
            {

                return;
            }

            if (!TryFetchDmsAccessToken(broker, out var token))
            {

                return;
            }

            // Send request over NATS (via CloudGateway DxM to the cloud)
            //engine.Log("Sending request to DCP...");

            var requestBody = new JObject();
            requestBody.Add("team_name", "JordyGitIsHere"); // TODO as input
            requestBody.Add("team_owner", "ruben.devos@3qtll8.onmicrosoft.com"); // TODO as input
            requestBody.Add("tenant_id", "3e20f27a-3ed5-4aad-83bc-335836538d60");// TODO remove
            var response = broker.ProtoReqReply(new DcpRequestResponseRequest()
            {
                DcpRequest = new DcpRequest()
                {
                    Token = token,
                    Path = "/api/dms-teams/v1-0/team",
                    HttpMethod = HttpMethod.Post.ToString(),
                    JsonBody = JsonConvert.SerializeObject(requestBody)
                }
            }, DcpRequestResponseResponse.Parser, 10000);

            if (response.ContainsError)
            {
                //engine.ExitFail($"Couldn't send the request to DCP because of {response.Error}.");
                return;
            }

            //engine.Log("Sent request to DCP.");

            // Cleanup
            broker.Dispose();

            // Respond
            if (response.DcpResponse.StatusCode == 200 || response.DcpResponse.StatusCode == 202)
            {
                //engine.ExitSuccess($"Done, the Team should be created soon. Response was: Code: {response.DcpResponse.StatusCode}, Body: {response.DcpResponse.Body}");
            }
            else
            {
                //engine.ExitFail($"Done, but didn't receive a successful response from DCP. Response was: Code: {response.DcpResponse.StatusCode}, Body: {response.DcpResponse.Body}");
            }
        }

        public void CreateChannel(string teamId, string channelName, string ownerEmail, string[] memberEmails)
        {
            throw new NotImplementedException();
        }

        public void SendNotification(string reference, string message)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="broker">Don't forget to dispose the broker after use!</param>
        /// <returns></returns>
        private bool TryConnectToMessageBroker(out ISLMessageBroker broker)
        {
            // Connect to NATS
            //engine.Log("Connecting to NATS...");

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

                //engine.Log($"Failed to connect to NATS, retrying later... ({i + 1})");

                Task.Delay(2000).Wait();
            }

            if (broker == null)
            {
                //engine.ExitFail($"Couldn't connect to NATs within {i + 1} retries.");
                return false;
            }

            //engine.Log("Connected to NATS.");
            return true;
        }

        private bool TryFetchDmsAccessToken(ISLMessageBroker broker, out string accessToken)
        {
            // Fetch dms authentication token from CloudGateway using NATS
            //engine.Log("Fetching DMS Authentication token...");
            accessToken = null;
            var tokenResponse = broker.ProtoReqReply(new GetCloudAccessTokenRequest()
            {
                Scopes = "6091cf86-293d-40ae-ba35-8378f60db93e/.default"
            }, GetCloudAccessTokenResponse.Parser);

            if (tokenResponse.Error != null && tokenResponse.Error.ContainsError)
            {
                //engine.ExitFail($"Couldn't fetch DMS Authentication token because of {string.Join(";", tokenResponse.Error.Errors.Select(e => $"{e.Type}: {e.Message}"))}.");
                return false;
            }

            if (tokenResponse.ExpirationDate.ToDateTimeOffset() <= DateTimeOffset.UtcNow)
            {
                //engine.ExitFail("Received an expired DMS Authentication token.");
                return false;
            }

            //engine.Log("Fetched DMS Authentication token.");
            accessToken = tokenResponse.AccessToken;
            return true;
        }
    }
}