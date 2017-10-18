using System.Windows;

namespace Screensaver
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        /// <summary>
        ///     Screensaver arguments
        ///     /s – Start the screensaver
        ///     /p – Preview the screensaver
        ///     /c – Configure the screensaver
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            string args = e.Args.Length > 0 ? e.Args[0].ToLower() : "";

            switch (args)
            {
                case "/p":
                    Screensaver.Main.Instance.Start();
                    break;
                case "/c":
                    Screensaver.Main.Instance.ShowConfig();
                    break;
                default:
                    Screensaver.Main.Instance.Start();
                    break;
            }
        }
    }
}