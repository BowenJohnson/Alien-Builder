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

namespace Alien_Builder
{
    /// <summary>
    /// Interaction logic for BuildPage.xaml
    /// </summary>
    public partial class BuildPage : Page
    {
        public BuildPage()
        {
            InitializeComponent();
            frmBuild.Content = new CareerPage();
        }

        private void btnCareer_Click(object sender, RoutedEventArgs e)
        {
            frmBuild.Content = new CareerPage();
        }

        private void btnStats_Click(object sender, RoutedEventArgs e)
        {
            frmBuild.Content = new StatsPage();
        }
    }
}
