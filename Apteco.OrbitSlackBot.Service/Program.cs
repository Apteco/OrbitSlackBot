using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Apteco.OrbitSlackBot.Core;

namespace Apteco.OrbitSlackBot.Service
{
  static class Program
  {
    #region private methods
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    private static void Main()
    {
      string baseUrl = GetAppSettingValue("baseUrl");
      string dataView = GetAppSettingValue("dataView");
      string username = GetAppSettingValue("username");
      string password = GetAppSettingValue("password");
      string slackToken = GetAppSettingValue("slackToken");

      if (!Environment.UserInteractive)
      {
        string logFilePath = GetAppSettingValue("logfile");
        OrbitSlackBotService service = new OrbitSlackBotService(new FileLogger(logFilePath), baseUrl, dataView, username, password, slackToken);
        ServiceBase.Run(service);
      }
      else
      {
        new OrbitSlackBotService(new ConsoleLogger(), baseUrl, dataView, username, password, slackToken).Start();
      }
    }

    private static string GetAppSettingValue(string key)
    {
      try
      {
        AppSettingsReader appSettingsReader = new AppSettingsReader();
        return appSettingsReader.GetValue(key, typeof(string)) as string;
      }
      catch (Exception e)
      {
        throw new Exception("Can't read the "+key+" property from the app.config file: " +e);
      }
    }
    #endregion
  }
}
