using System;
using System.Threading;
using SlackAPI;
using SlackAPI.WebSocketMessages;

namespace Apteco.OrbitSlackBot.Core.Slack
{
  public class SlackClient : ISlackClient
  {
    #region private fields
    private SlackSocketClient client;
    #endregion

    #region public events
    public event Action<NewMessage> OnMessageReceived
    {
      add { client.OnMessageReceived += value; }
      remove { client.OnMessageReceived -= value; }
    }
    #endregion

    #region public properties
    public string SelfId
    {
      get { return client?.MySelf?.id; }
    }
    #endregion

    #region public constructor
    public SlackClient(string slackToken)
    {
      client = new SlackSocketClient(slackToken);
    }
    #endregion

    #region public methods
    public void Connect(Action callback = null)
    {
      ManualResetEventSlim clientConnected = new ManualResetEventSlim(false);
      client.Connect(connected => 
        {
          clientConnected.Set();
          callback?.Invoke();
        },
        () => { }
      );
      clientConnected.Wait(10000);
      if (!clientConnected.IsSet)
        throw new Exception("Waited 10 seconds and failed to connect to Slack");
    }

    public void RefreshChannelList(Action callback = null)
    {
      client.GetChannelList((clr) =>
      {
        callback?.Invoke();
      });
    }

    public void RefreshUserList(Action callback = null)
    {
      client.GetUserList((clr) =>
      {
        callback?.Invoke();
      });
    }

    public bool IsDirectMessageChannel(string channelId)
    {
      return client.DirectMessageLookup.ContainsKey(channelId);
    }

    public string GetUsername(string userId)
    {
      if (userId == null)
        return "<unknown - us?>";

      if (!client.UserLookup.TryGetValue(userId, out User user))
        return "<unknown>";

      return user.name;
    }

    public string GetChannelName(string channelId)
    {
      if (channelId == null)
        return "<unknown>";

      if (!client.ChannelLookup.TryGetValue(channelId, out Channel channel))
        return "<unknown>";

      return channel.name;
    }

    public void PostMessage(string channelId, string message, Action callback = null)
    {
      client.PostMessage((clr) =>
      {
        callback?.Invoke();
      }, channelId, message);
    }
    #endregion
  }
}
