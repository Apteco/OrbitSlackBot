using System;
using System.Threading;
using Apteco.OrbitSlackBot.Core.Slack;
using SlackAPI.WebSocketMessages;

namespace Apteco.OrbitSlackBot.Core
{
  public class SlackBot
  {
    #region private fields
    private string slackToken;
    private ISlackClientFactory slackClientFactory;
    private bool running;
    private Thread thread;
    private IResponseHandler responseHandler;
    private ILogger logger;
    #endregion

    #region public constructor
    public SlackBot(ISlackClientFactory slackClientFactory, IResponseHandler responseHandler, ILogger logger, string slackToken)
    {
      this.slackClientFactory = slackClientFactory;
      this.slackToken = slackToken;
      this.responseHandler = responseHandler;
      this.logger = logger;
    }
    #endregion

    #region public methods
    public void Start()
    {
      if (running)
      {
        logger.Log("Start called on an already running SlackBot - ignoring");
        return;
      }

      thread = new Thread(Run);
      thread.Start();
    }

    public void Stop()
    {
      if (!running)
      {
        logger.Log("Stop called on an already stopped SlackBot - ignoring");
        return;
      }

      running = false;
      thread.Join();
    }
    #endregion

    #region private methods
    private void Run()
    {
      logger.Log("Starting SlackBot message loop");
      try
      {
        running = true;

        ISlackClient client = slackClientFactory.CreateSlackClient(slackToken);
        client.OnMessageReceived += (message) =>
        {
          try
          {
            if (message.channel == null)
              return;

            if (IsMessageFromBot(client, message))
              return;

            if (client.IsDirectMessageChannel(message.channel))
            {
              logger.Log("DM from " + client.GetUsername(message.user) + " at "+ message.ts.ToShortTimeString()+": " + message.text);
              string response = responseHandler.GenerateResponse(message.text, true);
              if (response != null)
              {
                client.PostMessage(message.channel, response, () =>
                {
                  logger.Log("Sent DM back to " + client.GetUsername(message.user) + ": " + response);
                });
              }
            }
            else
            {
              logger.Log("Message in channel " + client.GetChannelName(message.channel) + " at "+ message.ts.ToShortTimeString() + " from " + client.GetUsername(message.user) + ": " + message.text);
              string response = responseHandler.GenerateResponse(message.text, false);
              if (response != null)
              {
                client.PostMessage(message.channel, response, () =>
                {
                  logger.Log("Sent message to channel " + client.GetChannelName(message.channel) + ": " + response);
                });
              }
            }
          }
          catch (Exception e)
          {
            logger.Log("Got exception when processing message:" + e);
          }
        };

        client.Connect(() => { logger.Log("successfully connected"); });
        client.RefreshUserList(() => { logger.Log("refreshed users"); });
        client.RefreshChannelList(() => { logger.Log("refreshed channels"); });

        while (running)
        {
          Thread.Sleep(1000);
        }
      }
      catch (Exception e)
      {
        logger.Log("Got exception when running SlackBot thread: "+e);
        running = false;
      }
      logger.Log("Finished SlackBot message loop");
    }

    private bool IsMessageFromBot(ISlackClient client, NewMessage message)
    {
      return message.user == null || message.user == client.SelfId;
    }
    #endregion
  }
}
