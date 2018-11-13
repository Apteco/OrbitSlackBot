using Apteco.OrbitSlackBot.ApiClient.Api;
using Apteco.OrbitSlackBot.ApiClient.Model;

namespace Apteco.OrbitSlackBot.Core.Orbit
{
  public interface IApiConnectorFactory
  {
    #region public methods
    ISessionsApi CreateSessionsApi(SessionDetails sessionDetails);
    IPeopleStageApi CreatePeopleStageApi(SessionDetails sessionDetails);
    #endregion
  }
}
