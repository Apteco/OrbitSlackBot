using System;
using System.Collections.Generic;
using System.Linq;
using Apteco.OrbitSlackBot.ApiClient.Model;
using Apteco.OrbitSlackBot.Core.Orbit;

namespace Apteco.OrbitSlackBot.Core
{
  public class OrbitResponseHandler : IResponseHandler
  {
    #region private fields
    private IOrbitApiClient apiClient;
    #endregion

    #region public constructor
    public OrbitResponseHandler(IOrbitApiClient apiClient)
    {
      this.apiClient = apiClient;
    }
    #endregion

    #region public methods
    public string GenerateResponse(string message, bool isDirectMessage)
    {
      if (message == null)
        return null;

      if (isDirectMessage && (string.Equals(message, "Hi", StringComparison.OrdinalIgnoreCase) ||
                              string.Equals(message, "Hi!", StringComparison.OrdinalIgnoreCase) ||
                              string.Equals(message, "Hello", StringComparison.OrdinalIgnoreCase) ||
                              string.Equals(message, "Hello!", StringComparison.OrdinalIgnoreCase)))
      {
        return ReplyHello();
      }
      if (isDirectMessage && (string.Equals(message, "Thanks", StringComparison.OrdinalIgnoreCase) ||
                              string.Equals(message, "Thanks!", StringComparison.OrdinalIgnoreCase) ||
                              string.Equals(message, "Cheers", StringComparison.OrdinalIgnoreCase) ||
                              string.Equals(message, "Cheers!", StringComparison.OrdinalIgnoreCase) ||
                              string.Equals(message, "Great", StringComparison.OrdinalIgnoreCase) ||
                              string.Equals(message, "Great!", StringComparison.OrdinalIgnoreCase)))
      {
        return ReplyThanks();
      }
      if (isDirectMessage && (string.Equals(message, ":slightly_smiling_face:", StringComparison.OrdinalIgnoreCase)))
      {
        return ReplySmiley();
      }
      if (isDirectMessage && (string.Equals(message, "Help", StringComparison.OrdinalIgnoreCase) ||
                              string.Equals(message, "What can you do?", StringComparison.OrdinalIgnoreCase)))
      {
        return ReplyHelp();
      }
      else if (string.Equals(message, "When did the last campaign run?", StringComparison.OrdinalIgnoreCase))
      {
        return ReplyWithLastRanCampaign();
      }
      else if (string.Equals(message, "How many comms have been sent today?", StringComparison.OrdinalIgnoreCase))
      {
        return ReplyWithCommsForDate(DateTime.Today);
      }
      else if (string.Equals(message, "How many campaigns have run today?", StringComparison.OrdinalIgnoreCase))
      {
        return ReplyWithCampaignsForDate(DateTime.Today);
      }

      return null;
    }
    #endregion

    #region private methods
    private string ReplyHello()
    {
      long arbitraryValue = DateTime.Now.Ticks % 3;
      switch (arbitraryValue)
      {
        case 1:
          return "Hi there!";

        case 2:
          return "Hello";

        default:
          return "Hi";
      }
    }

    private string ReplyThanks()
    {
      long arbitraryValue = DateTime.Now.Ticks % 3;
      switch (arbitraryValue)
      {
        case 1:
          return "No problem";

        case 2:
          return "S'ok";

        default:
          return "You're welcome";
      }
    }

    private string ReplySmiley()
    {
      return ":slightly_smiling_face:";
    }

    private string ReplyHelp()
    {
      return "I can respond to the following questions:\n" +
             " - When did the last campaign run?\n" +
             " - How many comms have been sent today?\n" +
             " - How many campaigns have run today?";
    }

    private string ReplyWithLastRanCampaign()
    {
      PeopleStageSystemSummary firstSystem = apiClient.GetPeopleStageSystems()?.FirstOrDefault();
      List<ElementStatus> campaigns = apiClient.GetPeopleStageCampaigns(firstSystem);
      ElementStatus lastRanCampaign = campaigns?.OrderByDescending(c => c.LastRan)?.FirstOrDefault();

      if (lastRanCampaign?.LastRan == null)
        return "I don't know - I don't have any campaign information";
      else
        return lastRanCampaign.Description + " last ran " + FormatDateForReply("on", lastRanCampaign.LastRan.Value);
    }

    private string ReplyWithCommsForDate(DateTime dateTime)
    {
      PeopleStageSystemSummary firstSystem = apiClient.GetPeopleStageSystems()?.FirstOrDefault();
      CommunicationStatistics commsStats = apiClient.GetPeopleStageCommunicationsStatsForProgramme(firstSystem);

      if (commsStats == null)
        return "I don't know - I don't have any communication stats";

      int dateIndex = commsStats.Days.IndexOf(dateTime.ToString("yyyy-MM-dd"));
      if (dateIndex < 0)
        return "I don't know - I don't have the number of communication for " + FormatDateForReply("", dateTime);

      long? comms = commsStats.CommunicationsCounts.Count < dateIndex? null : commsStats.CommunicationsCounts[dateIndex];
      if (comms == null)
        return "I don't know - I don't have the number of communication for " + FormatDateForReply("", dateTime);
      else
        return comms.Value.ToString("N0") + " communications were sent " + FormatDateForReply("on", dateTime);
    }

    private string ReplyWithCampaignsForDate(DateTime dateTime)
    {
      PeopleStageSystemSummary firstSystem = apiClient.GetPeopleStageSystems()?.FirstOrDefault();
      CommunicationStatistics commsStats = apiClient.GetPeopleStageCommunicationsStatsForProgramme(firstSystem);

      if (commsStats == null)
        return "I don't know - I don't have any communication stats";

      int dateIndex = commsStats.Days.IndexOf(dateTime.ToString("yyyy-MM-dd"));
      if (dateIndex < 0)
        return "I don't know - I don't have the number of campaigns for " + FormatDateForReply("", dateTime);

      long? campaigns = commsStats.CampaignsCounts.Count < dateIndex? null : commsStats.CampaignsCounts[dateIndex];
      if (campaigns == null)
        return "I don't know - I don't have the number of campaigns for " + FormatDateForReply("", dateTime);
      else
        return campaigns.Value.ToString("N0") + " campaigns have run " + FormatDateForReply("on", dateTime);
    }

    private string FormatDateForReply(string prefix, DateTime dateTime)
    {
      if (dateTime.Date == DateTime.Today)
        return "today";
      else
        return (string.IsNullOrWhiteSpace(prefix)? "" : prefix + " ") + dateTime.ToShortDateString();
    }
    #endregion
  }
}
