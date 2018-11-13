using System;
using System.ServiceProcess;
using Apteco.OrbitSlackBot.Core;
using Apteco.OrbitSlackBot.Core.Orbit;
using Apteco.OrbitSlackBot.Core.Slack;

namespace Apteco.OrbitSlackBot.Service
{
  public partial class OrbitSlackBotService : ServiceBase
  {
    #region private fields
    private ILogger logger;
    private SlackBot bot;
    private string baseUrl;
    private string dataView;
    private string username;
    private string password;
    private string slackToken;
    #endregion

    #region public constructors
    public OrbitSlackBotService()
    : this(new ConsoleLogger(), null, null, null, null, null)
    {
    }

    public OrbitSlackBotService(ILogger logger, string baseUrl, string dataView, string username, string password, string slackToken)
    {
      this.logger = logger;
      this.baseUrl = baseUrl;
      this.dataView = dataView;
      this.username = username;
      this.password = password;
      this.slackToken = slackToken;

      InitializeComponent();
    }
    #endregion

    #region public methods
    public void Start()
    {
      OnStart(new string[0]);
    }

    public void Pause()
    {
      OnPause();
    }

    public void Continue()
    {
      OnContinue();
    }
    #endregion

    #region protected methods
    protected override void OnStart(string[] args)
    {
      base.OnStart(args);

      EnsureOrbitConnectionParametersCorrect();

      logger.Log("Starting Orbit Slackbot - connecting to Orbit API");

      OrbitApiClient apiClient = new OrbitApiClient(dataView, new ApiConnectorFactory(baseUrl));
      if (!apiClient.Login(username, password))
        throw new Exception("Can't log in to the dataview " + dataView + " with username " + username + " using the API at " + baseUrl);

      logger.Log("Starting Orbit Slackbot - successfully connected to Orbit API");
      OrbitResponseHandler responseHandler = new OrbitResponseHandler(apiClient);

      logger.Log("Starting Orbit Slackbot - connecting to Slack");
      bot = new SlackBot(new SlackClientFactory(), responseHandler, logger, slackToken);
      bot.Start();

      logger.Log("Successfully started Orbit Slackbot");
    }

    protected override void OnStop()
    {
      base.OnStop();

      logger.Log("Stopping Orbit Slackbot");
      bot?.Stop();
    }

    protected override void OnPause()
    {
      base.OnPause();

      logger.Log("Pause called for Orbit Slackbot Service, but ignoring");
    }

    protected override void OnContinue()
    {
      base.OnContinue();

      logger.Log("Continue called for Orbit Slackbot Service, but ignoring");
    }
    #endregion

    #region private methods
    private void EnsureOrbitConnectionParametersCorrect()
    {
      if (string.IsNullOrWhiteSpace(baseUrl))
        throw new Exception("The baseUrl has not been set");

      if (string.IsNullOrWhiteSpace(dataView))
        throw new Exception("The dataView has not been set");

      if (string.IsNullOrWhiteSpace(username))
        throw new Exception("The username has not been set");

      if (string.IsNullOrWhiteSpace(slackToken))
        throw new Exception("The slackToken has not been set");
    }
    #endregion
  }
}
