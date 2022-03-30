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
    /// Interaction logic for GearPage.xaml
    /// </summary>
    public partial class GearPage : Page
    {
        public GearPage()
        {
            InitializeComponent();
            frmGear.Content = new EquipmentPage();
        }

        private void btnEquipment_Click(object sender, RoutedEventArgs e)
        {
            frmGear.Content = new EquipmentPage();
        }

        private void btnInventory_Click(object sender, RoutedEventArgs e)
        {
            frmGear.Content = new InventoryPage();
        }
    }
}
