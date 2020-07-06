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

using MW5MercsEnhancedStats.Controlls;

namespace MW5MercsEnhancedStats.Pages
{
    /// <summary>
    /// Interaktionslogik für SalvagePage.xaml
    /// </summary>
    public partial class SalvagePage : Page
    {
        public SalvagePage()
        {
            InitializeComponent();
        }

        private void btAddSalvage_Click(object sender, RoutedEventArgs e)
        {
            spSalvage.Children.Add(new ListItemSalvage());
        }
    }
}
