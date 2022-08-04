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
        /// <param name="addedTeamMembersEmails">The members successfully added to the team.</param>
        /// <returns>If at least one member could be added to the team, the members added to the team are returned in <paramref name="addedTeamMembersEmails"/>.</returns>
        /// <remarks>The organizations Microsoft Teams tenant can be configured in the <a href="https://admin.dataminer.services">DCP Admin App</a>.</remarks>
        bool TryAddTeamMember(Action<string> log, string teamId, string[] teamMemberEmails, out string[] addedTeamMembersEmails);

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

        /// <summary>
        /// Tries to send a notification/message in the given channel in Microsoft Teams.
        /// </summary>
        /// <param name="log">An action used to log. Example: engine.Log</param>
        /// <param name="channelId">The id of the channel where to send the notification/message.</param>
        /// <param name="notification">The notification/message to send in the channel.</param>
        /// <returns>If the notification/message could be sent to the channel.</returns>
        /// <remarks>The organizations Microsoft Teams tenant can be configured in the <a href="https://admin.dataminer.services">DCP Admin App</a>.</remarks>
        bool TrySendNotification(Action<string> log, string channelId, string notification);
    }
}