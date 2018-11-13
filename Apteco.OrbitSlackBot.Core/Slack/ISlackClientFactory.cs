namespace Apteco.OrbitSlackBot.Core.Slack
{
  public interface ISlackClientFactory
  {
    #region public methods
    ISlackClient CreateSlackClient(string slackToken);
    #endregion
  }
}
