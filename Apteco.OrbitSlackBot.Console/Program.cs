using System;
using Apteco.OrbitSlackBot.Core;
using Apteco.OrbitSlackBot.Core.Orbit;
using Apteco.OrbitSlackBot.Core.Slack;

namespace Apteco.OrbitSlackBot.Console
{
  public class Program
  {
    private static void Main(string[] args)
    {
      if (args == null || args.Length < 5)
      {
        System.Console.WriteLine("Usage: OrbitSlackBot-Console.exe <Orbit API base URL> <DataView name> <username> <password> <slackToken>");
        return;
      }

      Run(args[0], args[1], args[2], args[3], args[4]);
    }

    private static void Run(string baseUrl, string dataView, string username, string password, string slackToken)
    {
      OrbitApiClient apiClient = new OrbitApiClient(dataView, new ApiConnectorFactory(baseUrl));
      if (!apiClient.Login(username, password))
        throw new Exception("Can't log in to the dataview "+dataView+" with username "+username+" using the API at "+baseUrl);

      OrbitResponseHandler responseHandler = new OrbitResponseHandler(apiClient);

      SlackBot bot = new SlackBot(new SlackClientFactory(), responseHandler, new ConsoleLogger(), slackToken);
      bot.Start();

      System.Console.WriteLine("Orbit Slackbot started.  Press return to stop");
      System.Console.WriteLine();
      System.Console.ReadLine();

      bot.Stop();
    }
  }
}
