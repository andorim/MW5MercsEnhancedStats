using MW5MercsEnhancedStats.Controlls;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MW5MercsEnhancedStats
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isHidden;
        public MainWindow()
        {
            InitializeComponent();
            App.main = this;
            isHidden = false;
            grMain.Children.Add(App.mainMenu);
        }
        public void ClickHide()
        {
            if (!isHidden)
            {
                TryHide(this);
                isHidden = true;
            }
            else
            {
                TryShow(this);
                isHidden = false;
            }
        }
        private void TryHide(object win)
        {
            try
            {
                Window w = (Window)win;
                w.Hide();
                w.Topmost = false;
            }
            catch (System.InvalidOperationException ex)
            {
                isHidden = !isHidden;
            }
            catch (System.NullReferenceException ex)
            {
                isHidden = !isHidden;
            }
        }

        private void TryShow(object win)
        {
            try
            {
                Window w = (Window)win;
                w.Show();
                w.Topmost = true;
            }
            catch (System.InvalidOperationException ex)
            {
                isHidden = !isHidden;
            }
            catch (System.NullReferenceException ex)
            {
                isHidden = !isHidden;
            }
        }

        public void btMenu_Click(object sender, RoutedEventArgs e)
        {
            if (App.mainMenu.spMenu.Margin.Equals(new Thickness(0,0,0,0)))
            {
                
                App.mainMenu.BeginStoryboard((Storyboard)App.mainMenu.FindResource("slideOut"));
                frMain.Margin = new Thickness(0, 0, 0, 0);
            }
            else if(App.mainMenu.spMenu.Margin.Equals(new Thickness(-150, 0, 0, 0)))
            {
                App.mainMenu.BeginStoryboard((Storyboard)App.mainMenu.FindResource("slideIn"));
                frMain.Margin = new Thickness(0, 0, 0, 0);

            }
        }

        private void spNavigation_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
