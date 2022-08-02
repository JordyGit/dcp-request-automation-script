namespace ChatIntegrationHelper;

public interface ITeamsChatIntegrationHelper
{
    void CreateTeam(string teamName, string ownerEmail, string[] memberEmails);
    void CreateChannel(string teamId, string channelName, string ownerEmail, string[] memberEmails); 
    void SendNotification(string reference, string message);
}