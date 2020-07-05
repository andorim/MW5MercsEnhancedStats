using MW5MercsEnhancedStats.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MW5MercsEnhancedStats.Controlls
{
    /// <summary>
    /// Interaktionslogik für MainMenu.xaml
    /// </summary>
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnHide_Click(object sender, RoutedEventArgs e)
        {
            App.main.ClickHide();
        }

        private void btnNewMission_Click(object sender, RoutedEventArgs e)
        {
            App.main.frMain.Navigate(App.newMission);
        }

    }
}
