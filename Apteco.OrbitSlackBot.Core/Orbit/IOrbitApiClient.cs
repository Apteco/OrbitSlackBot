using System.Collections.Generic;
using Apteco.OrbitSlackBot.ApiClient.Model;

namespace Apteco.OrbitSlackBot.Core.Orbit
{
  public interface IOrbitApiClient
  {
    #region public methods
    bool Login(string username, string password);
    void Logout();
    List<PeopleStageSystemSummary> GetPeopleStageSystems();
    List<ElementStatus> GetPeopleStageCampaigns(PeopleStageSystemSummary systemSummary);
    CommunicationStatistics GetPeopleStageCommunicationsStatsForProgramme(PeopleStageSystemSummary systemSummary);
    #endregion
  }
}
