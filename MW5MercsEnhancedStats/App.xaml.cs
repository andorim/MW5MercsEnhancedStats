using MW5MercsEnhancedStats.Controlls;
using MW5MercsEnhancedStats.Pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using System.Windows.Input; //Key
using System.Windows.Threading; //Task

namespace MW5MercsEnhancedStats
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        public static MainWindow main;
        public static MainMenu mainMenu;
        public static NewMission newMission;
        KeyboardListener KListener = new KeyboardListener();

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            mainMenu = new MainMenu();
            newMission = new NewMission();
            KListener.KeyDown += new RawKeyEventHandler(KListener_KeyDown);
        }
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            KListener.Dispose();
        }







        #region Keyboard_Listener
        //==========================< Region: Keyboard_Listener >==========================

        /// <summary>
        /// Binde Taste Prnt an die Application
        /// </summary>
        public void KListener_KeyDown(object sender, RawKeyEventArgs args)
        {
            if (args.Key.ToString() == MW5MercsEnhancedStats.Properties.Settings.Default.HideKey)
            {
                this.Dispatcher.BeginInvoke((System.Threading.ThreadStart)delegate
                {
                    main.ClickHide();
                });

            }
        }
        //==========================</ Region: Keyboard_Listener >==========================
        #endregion
    }
}
