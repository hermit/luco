using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Luco
{
  /// <summary>
  /// App.xaml の相互作用ロジック
  /// </summary>
  public partial class App : Application
  {
    public App()
    {
      // セーブデータを読む
      //var entry1 = Luco.Properties.Settings.Default.entry1;
    }

    private void App_Exit(object sender, ExitEventArgs e)
    {
      Luco.Properties.Settings.Default.Save();
    }
  }
}
