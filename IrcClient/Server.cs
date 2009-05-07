
namespace IrcClient
{
  /// <summary>
  /// IRCクライアントアプリケーションから、接続するサーバを扱うためのクラス
  /// </summary>
  public class Server
  {
    public string Name { get; set; }

    public string Host { get; set; }
    public ushort Port { get; set; }

    public string Nickname { get; set; }
    public string Password { get; set; }
  }
}
