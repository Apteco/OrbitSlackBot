using System;
using System.Collections.Generic;
using Apteco.OrbitSlackBot.ApiClient.Api;
using Apteco.OrbitSlackBot.ApiClient.Model;

namespace Apteco.OrbitSlackBot.Core.Orbit
{
  public class OrbitApiClient : IOrbitApiClient
  {
    #region private fields
    private string dataView;
    private SessionDetails sessionDetails;
    private IApiConnectorFactory apiConnectorFactory;
    #endregion

    #region public constructor
    public OrbitApiClient(string dataView, IApiConnectorFactory apiConnectorFactory)
    {
      this.dataView = dataView;
      this.apiConnectorFactory = apiConnectorFactory;
    }
    #endregion

    #region public methods
    public bool Login(string username, string password)
    {
      ISessionsApi sessionsApi = apiConnectorFactory.CreateSessionsApi(null);
      SessionDetails details = sessionsApi.SessionsCreateSessionSimple(dataView, username, password);
      if (details?.AccessToken == null)
        return false;

      sessionDetails = details;
      return true;
    }

    public void Logout()
    {
      if (sessionDetails == null)
        throw new Exception("No session has been created - please log in");

      ISessionsApi sessionsApi = apiConnectorFactory.CreateSessionsApi(sessionDetails);
      sessionsApi.SessionsLogoutSession(dataView, sessionDetails.SessionId);
    }

    public List<PeopleStageSystemSummary> GetPeopleStageSystems()
    {
      if (sessionDetails == null)
        throw new Exception("No session has been created - please log in");

      IPeopleStageApi peopleStageApi = apiConnectorFactory.CreatePeopleStageApi(sessionDetails);
      PagedResultsPeopleStageSystemSummary summaries = peopleStageApi.PeopleStageGetPeopleStageSystems(dataView, null, null, null, 1000);
      return summaries?.List;
    }

    public List<ElementStatus> GetPeopleStageCampaigns(PeopleStageSystemSummary systemSummary)
    {
      if (sessionDetails == null)
        throw new Exception("No session has been created - please log in");

      IPeopleStageApi peopleStageApi = apiConnectorFactory.CreatePeopleStageApi(sessionDetails);
      string filter = "Type eq 'Campaign'";
      PagedResultsElementStatus statuses = peopleStageApi.PeopleStageGetPeopleStageElementStatusForDescendants(dataView, systemSummary.SystemName, systemSummary.ProgrammeId, filter, null, 0, 1000000);
      return statuses?.List;
    }

    public CommunicationStatistics GetPeopleStageCommunicationsStatsForProgramme(PeopleStageSystemSummary systemSummary)
    {
      if (sessionDetails == null)
        throw new Exception("No session has been created - please log in");

      IPeopleStageApi peopleStageApi = apiConnectorFactory.CreatePeopleStageApi(sessionDetails);
      return peopleStageApi.PeopleStageGetPeopleStageElementCommunicationStatistics(dataView, systemSummary.SystemName, systemSummary.ProgrammeId);
    }
    #endregion
  }
}
