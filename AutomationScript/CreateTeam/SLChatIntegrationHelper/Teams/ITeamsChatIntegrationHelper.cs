using System;

namespace SLChatIntegrationHelper.Teams {

    public interface ITeamsChatIntegrationHelper
    {
        /// <summary>
        /// Tries to create a team in Microsoft Teams. The organizations Microsoft Teams tenant can be configured in the <a href="https://admin.dataminer.services">DCP Admin App</a>.
        /// </summary>
        /// <param name="log">An action used to log. Example: engine.Log</param>
        /// <param name="teamName">The name of the team to be created.</param>
        /// <param name="teamOwnerEmail">The email address of the owner of the team. Note this email address must be a part of the tenant.</param>
        /// <returns>If the team could be created.</returns>
        bool TryCreateTeam(Action<string> log, string teamName, string teamOwnerEmail);

        // TODO
        bool TryCreateChannel(Action<string> log, string teamId, string channelName, string ownerEmail, string[] memberEmails);

        // TODO
        bool TrySendNotification(Action<string> log, string reference, string message);
    }
}