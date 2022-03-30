using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frmMain.Content = new Start();
            //frmSubButtons.Content = new StartButtons();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Content = new Start();
            //frmSubButtons.Content = new StartButtons();
        }

        private void btnBuild_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Content = new BuildPage();
            //frmSubButtons.Content = new BuildButtons();
        }
        private void btnGear_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Content = new GearPage();
            //frmSubButtons.Content = new GearButtons();
        }
        private void btnManage_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Content = new ManagePage();
            //frmSubButtons.Content = new ManageButtons();
        }

        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
