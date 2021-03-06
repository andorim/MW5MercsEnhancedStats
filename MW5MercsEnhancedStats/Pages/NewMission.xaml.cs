﻿using System;
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
    /// Interaktionslogik für NewMission.xaml
    /// </summary>
    public partial class NewMission : Page
    {
        LoadOutPage loadOutPage;
        SalvagePage salvagePage;
        
        public NewMission()
        {
            loadOutPage = new LoadOutPage();
            salvagePage = new SalvagePage();
            InitializeComponent();
            frLoadSal.Navigate(loadOutPage);
        }

        private void btnLoadOut_Click(object sender, RoutedEventArgs e)
        {
            frLoadSal.Navigate(loadOutPage);
        }

        private void btnSalvage_Click(object sender, RoutedEventArgs e)
        {
            frLoadSal.Navigate(salvagePage);
        }
    }
}
