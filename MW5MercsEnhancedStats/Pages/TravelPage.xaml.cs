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

namespace MW5MercsEnhancedStats.Pages
{
    /// <summary>
    /// Interaktionslogik für TravelPage.xaml
    /// </summary>
    public partial class TravelPage : Page
    {
        public TravelPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            tbOrigin.Text = App.main.tbSystem.Text;
        }

        private void cbJumps_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbI = (ComboBoxItem) cbJumps.SelectedItem;
            int jumps = int.Parse(cbI.Content.ToString());
            int costs = jumps * 50000;
            tbJumpCosts.Text = costs.ToString();     
        }
    }
}
