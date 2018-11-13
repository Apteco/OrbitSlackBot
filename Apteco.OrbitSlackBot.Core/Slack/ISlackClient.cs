using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlackAPI.WebSocketMessages;

namespace Apteco.OrbitSlackBot.Core.Slack
{
  public interface ISlackClient
  {
    #region public events
    event Action<NewMessage> OnMessageReceived;
    #endregion

    #region public properties
    string SelfId { get; }
    #endregion

    #region public methods
    void Connect(Action callback = null);
    void RefreshChannelList(Action callback = null);
    void RefreshUserList(Action callback = null);
    bool IsDirectMessageChannel(string channelId);
    string GetUsername(string userId);
    string GetChannelName(string channelId);
    void PostMessage(string channelId, string message, Action callback = null);
    #endregion
  }
}
