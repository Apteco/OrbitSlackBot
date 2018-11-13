using System;
using System.IO;
using Apteco.OrbitSlackBot.Core;

namespace Apteco.OrbitSlackBot.Service
{
  public class FileLogger : ILogger
  {
    #region private fields
    private string filename;
    #endregion

    public FileLogger(string filename)
    {
      this.filename = filename;
    }

    #region public methods
    public void Log(string message)
    {
      string logDirectory = Path.GetDirectoryName(filename);
      if (!Directory.Exists(logDirectory))
        Directory.CreateDirectory(logDirectory);

      using (StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Append)))
      {
        sw.WriteLine(DateTime.Now.ToString("O")+ "\t" + message);
      }
    }
    #endregion
  }
}
