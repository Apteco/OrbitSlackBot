namespace Apteco.OrbitSlackBot.Core.Slack
{
  public class SlackClientFactory : ISlackClientFactory
  {
    #region public methods
    public ISlackClient CreateSlackClient(string slackToken)
    {
      return new SlackClient(slackToken);
    }
    #endregion
  }
}
