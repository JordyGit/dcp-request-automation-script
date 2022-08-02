using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace SLChatIntegrationHelper.Teams
{
    public class TeamsChatIntegrationHelper : ITeamsChatIntegrationHelper
    {
        public bool TryCreateTeam(Action<string> log, string teamName, string teamOwnerEmail)
        {
            // Connect
            if (!Helper.TryConnectToMessageBroker(log, out var broker))
            {
                return false;
            }

            // Authenticate
            if (!Helper.TryFetchDmsAccessToken(log, broker, out var token))
            {
                return false;
            }

            // Send call
            var body = new JObject();
            body.Add("teamName", teamName);
            body.Add("teamOwner", teamOwnerEmail);

            if (!Helper.TrySendDcpRequest(log, broker, HttpMethod.Post, "/api/dms-teams/v1-0/team", token, body, 10000, out var response))
            {
                // Cleanup
                broker.Dispose();

                return false;
            }

            // Cleanup
            broker.Dispose();

            // Finish
            if (response.StatusCode == 200 || response.StatusCode == 202)
            {
                log($"Done, the team should be created soon. Response was: Code: {response.StatusCode}, Body: {response.Body}");
                return true;
            }

            log($"Failed, didn't receive a successful response from DCP. Response was: Code: {response.StatusCode}, Body: {response.Body}");
            return false;
        }

        public bool TryCreateChannel(Action<string> log, string teamId, string channelName, string ownerEmail, string[] memberEmails)
        {
            throw new NotImplementedException();
        }

        public bool TrySendNotification(Action<string> log, string reference, string message)
        {
            throw new NotImplementedException();
        }
    }
}