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
    /// Interaction logic for ManagePage.xaml
    /// </summary>
    public partial class ManagePage : Page
    {
        public ManagePage()
        {
            InitializeComponent();
            frmManage.Content = new CharacterPage();
        }

        private void btnCharacter_Click(object sender, RoutedEventArgs e)
        {
            frmManage.Content = new CharacterPage();
        }

        private void btnBackStory_Click(object sender, RoutedEventArgs e)
        {
            frmManage.Content = new BackStoryPage();
        }
    }
}
