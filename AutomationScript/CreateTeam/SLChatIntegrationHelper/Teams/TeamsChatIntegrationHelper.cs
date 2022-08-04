using System;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SLChatIntegrationHelper.Teams
{
    public class TeamsChatIntegrationHelper : ITeamsChatIntegrationHelper
    {
        public bool TryCreateTeam(Action<string> log, string teamName, string teamOwnerEmail, out string teamId)
        {
            teamId = null;

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
            if (response.StatusCode != 202)
            {
                log($"Failed, didn't receive a successful response from DCP. Response was: Code: {response.StatusCode}, Body: {response.Body}");
                return false;
            }

            log($"Received a successful response, the team should be created soon. Response was: Code: {response.StatusCode}, Body: {response.Body}");

            // Convert response
            try
            {
                var responseObject = JsonConvert.DeserializeObject<JObject>(response.Body);
                if (responseObject == null)
                {
                    log("Couldn't deserialize the response.");
                    return false;
                }

                if (!responseObject.TryGetValue("teamId", out var jValue))
                {
                    log("Couldn't parse the team id from the response.");
                    return false;
                }

                var receivedTeamId = jValue.Value<string>();
                if (string.IsNullOrWhiteSpace(receivedTeamId))
                {
                    log("The team id from the response is not valid, null or empty.");
                    teamId = null;
                    return false;
                }

                teamId = receivedTeamId;
                return true;
            }
            catch (Exception e)
            {
                log($"An exception occurred while converting the response from DCP with message: {e.Message}.");
                return false;
            }
        }

        public bool TryAddTeamMember(Action<string> log, string teamId, string[] teamMemberEmails, out string[] addedTeamMembersEmails)
        {
            addedTeamMembersEmails = null;

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
            body.Add("teamMembers", JArray.FromObject(teamMemberEmails));

            if (!Helper.TrySendDcpRequest(log, broker, HttpMethod.Post, $"/api/dms-teams/v1-0/team/{teamId}/members", token, body, 10000, out var response))
            {
                // Cleanup
                broker.Dispose();

                return false;
            }

            // Cleanup
            broker.Dispose();

            // Finish
            // TODO REMOVE 204
            // TODO REMOVE 204
            // TODO REMOVE 204
            // TODO REMOVE 204
            // TODO REMOVE 204
            if (response.StatusCode != 200 && response.StatusCode != 207 && response.StatusCode != 204)
            {
                log($"Failed, didn't receive a successful response from DCP. Response was: Code: {response.StatusCode}, Body: {response.Body}");
                return false;
            }


            // TODO ADJUST LOGS
            if (response.StatusCode == 200)
            {
                log($"Received a successful response, all the members were added to the team. Response was: Code: {response.StatusCode}, Body: {response.Body}");
            }
            else if (response.StatusCode == 207)
            {
                log(
                    $"Received a partial successful response, only some members were added to the team. Response was: Code: {response.StatusCode}, Body: {response.Body}");
            }
            // TODO REMOVE WHEN NEW API V 
            // TODO REMOVE WHEN NEW API V 
            // TODO REMOVE WHEN NEW API V 
            // TODO REMOVE WHEN NEW API V 
            // TODO REMOVE WHEN NEW API V 
            else if (response.StatusCode == 204)
            {
                log($"Received a successful response, all the members were added to the team. Response was: Code: {response.StatusCode}, Body: {response.Body}");
            }

            // Convert response
            try
            {
                var responseObject = JsonConvert.DeserializeObject<JObject>(response.Body);
                if (responseObject == null)
                {
                    log("Couldn't deserialize the response.");
                    return false;
                }

                // TODO align with api :)
                // TODO align with api :)
                // TODO align with api :)
                // TODO align with api :)
                // TODO align with api :)
                if (!responseObject.TryGetValue("successfullyAddedMembers", out var jValue))
                {
                    log("Couldn't parse the list from the response.");
                    return false;
                }

                if (!(jValue is JArray responses))
                {
                    log("The list from the response is not valid or null.");
                    return false;
                }

                addedTeamMembersEmails = responses.Values<string>().ToArray();
                return true;
            }
            catch (Exception e)
            {
                log($"An exception occurred while converting the response from DCP with message: {e.Message}.");
                return false;
            }
        }

        public bool TryCreateChannel(Action<string> log, string teamId, string channelName, string channelDescription, bool channelIsFavorite, out string channelId)
        {
            channelId = null;

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
            body.Add("channelName", channelName);
            body.Add("channelDescription", channelDescription);
            body.Add("isFavorite", channelIsFavorite);

            if (!Helper.TrySendDcpRequest(log, broker, HttpMethod.Post, $"/api/dms-teams/v1-0/team/{teamId}/channel", token, body, 10000, out var response))
            {
                // Cleanup
                broker.Dispose();

                return false;
            }

            // Cleanup
            broker.Dispose();

            // Finish
            if (response.StatusCode != 201)
            {
                log($"Failed, didn't receive a successful response from DCP. Response was: Code: {response.StatusCode}, Body: {response.Body}");
                return false;
            }

            log($"Received a successful response, the channel was created. Response was: Code: {response.StatusCode}, Body: {response.Body}");

            // Convert response
            try
            {
                var responseObject = JsonConvert.DeserializeObject<JObject>(response.Body);
                if (responseObject == null)
                {
                    log("Couldn't deserialize the response.");
                    return false;
                }
                
                if (!responseObject.TryGetValue("channelId", out var jValue))
                {
                    log("Couldn't parse the channel id from the response.");
                    return false;
                }

                var receivedTeamId = jValue.Value<string>();
                if (string.IsNullOrWhiteSpace(receivedTeamId))
                {
                    log("The channel id from the response is not valid, null or empty.");
                    channelId = null;
                    return false;
                }

                channelId = receivedTeamId;
                return true;
            }
            catch (Exception e)
            {
                log($"An exception occurred while converting the response from DCP with message: {e.Message}.");
                return false;
            }
        }

        public bool TrySendNotification(Action<string> log, string channelId, string notification)
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
            body.Add("notification", notification);

            if (!Helper.TrySendDcpRequest(log, broker, HttpMethod.Post, $"/api/dms-teams/v1-0/channel/{channelId}/notification", token, body, 10000, out var response))
            {
                // Cleanup
                broker.Dispose();

                return false;
            }

            // Cleanup
            broker.Dispose();

            // Finish
            if (response.StatusCode != 200)
            {
                log($"Failed, didn't receive a successful response from DCP. Response was: Code: {response.StatusCode}, Body: {response.Body}");
                return false;
            }

            log($"Received a successful response, the notification was sent to the channel. Response was: Code: {response.StatusCode}, Body: {response.Body}");
            return true;
        }
    }
}