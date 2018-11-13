using System;

namespace Apteco.OrbitSlackBot.Core
{
  public class ConsoleLogger : ILogger
  {
    #region public methods
    public void Log(string message)
    {
      Console.WriteLine(DateTime.Now.ToString("O") + "\t" + message);
    }
    #endregion
  }
}
