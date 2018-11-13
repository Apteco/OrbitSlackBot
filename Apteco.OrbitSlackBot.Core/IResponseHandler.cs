namespace Apteco.OrbitSlackBot.Core
{
  public interface IResponseHandler
  {
    #region public methods
    string GenerateResponse(string message, bool isDirectMessage);
    #endregion
  }
}
