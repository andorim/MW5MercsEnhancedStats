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
    /// Interaktionslogik für ListItemSalvage.xaml
    /// </summary>
    public partial class ListItemSalvage : UserControl
    {
        public ListItemSalvage()
        {
            InitializeComponent();
        }

        private void btDelSalvage_Click(object sender, RoutedEventArgs e)
        {

            StackPanel panel = (StackPanel)Parent;
            panel.Children.Remove(this);
        }
    }
}
