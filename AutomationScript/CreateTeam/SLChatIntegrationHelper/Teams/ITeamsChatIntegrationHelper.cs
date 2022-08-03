using System;

namespace SLChatIntegrationHelper.Teams {

    public interface ITeamsChatIntegrationHelper
    {
        /// <summary>
        /// Tries to create a team in Microsoft Teams.
        /// </summary>
        /// <param name="log">An action used to log. Example: engine.Log</param>
        /// <param name="teamName">The name of the team to be created.</param>
        /// <param name="teamOwnerEmail">The email address of the owner of the team. Note this email address must be a part of the tenant.</param>
        /// <param name="teamId">The id of the team if created successfully. Save this id for future use, for example in a memory file.</param>
        /// <returns>If the team could be created and in that case also the team id. Save this team id (in a memory file) for future use.</returns>
        /// <remarks>The organizations Microsoft Teams tenant can be configured in the <a href="https://admin.dataminer.services">DCP Admin App</a>.</remarks>
        bool TryCreateTeam(Action<string> log, string teamName, string teamOwnerEmail, out string teamId);

        /// <summary>
        /// Tries to add the given members to the given team in Microsoft Teams.
        /// </summary>
        /// <param name="log">An action used to log. Example: engine.Log</param>
        /// <param name="teamId">The id of the team where to add the members. This id is returned when creating a team using <see cref="TryCreateTeam"/>.</param>
        /// <param name="teamMemberEmails">The email addresses of the members to add to the team. Note these email addresses must be a part of the tenant.</param>
        /// <returns>If the members could be added to the team.</returns>
        /// <remarks>The organizations Microsoft Teams tenant can be configured in the <a href="https://admin.dataminer.services">DCP Admin App</a>.</remarks>
        bool TryAddTeamMember(Action<string> log, string teamId, string[] teamMemberEmails);

        /// <summary>
        /// Tries to create a channel in the given team in Microsoft Teams.
        /// </summary>
        /// <param name="log">An action used to log. Example: engine.Log</param>
        /// <param name="teamId">The id of the team where to create the channel. This id is returned when creating a team using <see cref="TryCreateTeam"/>.</param>
        /// <param name="channelName">The name of the channel to be created.</param>
        /// <param name="channelDescription">The description of the channel to be created.</param>
        /// <param name="channelIsFavorite">If the channel to be created should be marked as favorite.</param>
        /// <param name="channelId">The id of the channel if created successfully. Save this id for future use, for example in a memory file.</param>
        /// <returns>If the channel could be created in the team and in that case also the channel id. Save this channel id (in a memory file) for future use.</returns>
        /// <remarks>The organizations Microsoft Teams tenant can be configured in the <a href="https://admin.dataminer.services">DCP Admin App</a>.</remarks>
        bool TryCreateChannel(Action<string> log, string teamId, string channelName, string channelDescription, bool channelIsFavorite, out string channelId);

        // TODO will it be possible to have one method for channel / group chat messages/notifications or do we need 2?
        bool TrySendNotification(Action<string> log, string reference, string message);
    }
}