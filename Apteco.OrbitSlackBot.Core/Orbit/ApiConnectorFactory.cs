using System.Collections.Generic;
using Apteco.OrbitSlackBot.ApiClient.Api;
using Apteco.OrbitSlackBot.ApiClient.Client;
using Apteco.OrbitSlackBot.ApiClient.Model;

namespace Apteco.OrbitSlackBot.Core.Orbit
{
  public class ApiConnectorFactory : IApiConnectorFactory
  {
    #region private fields
    private string baseUrl;
    #endregion

    #region public constructor
    public ApiConnectorFactory(string baseUrl)
    {
      this.baseUrl = baseUrl;
    }
    #endregion

    #region public methods
    public ISessionsApi CreateSessionsApi(SessionDetails sessionDetails)
    {
      return new SessionsApi(CreateConfiguration(sessionDetails));
    }

    public IPeopleStageApi CreatePeopleStageApi(SessionDetails sessionDetails)
    {
      return new PeopleStageApi(CreateConfiguration(sessionDetails));
    }
    #endregion

    #region private methods
    private Configuration CreateConfiguration(SessionDetails sessionDetails)
    {
      Dictionary<string, string> defaultHeaders = new Dictionary<string, string>();
      if (sessionDetails != null)
      {
        defaultHeaders.Add("Authorization", "Bearer " + sessionDetails.AccessToken);
      }

      return new Configuration()
      {
        DefaultHeader = defaultHeaders,
        BasePath = baseUrl
      };
    }
    #endregion
  }
}
