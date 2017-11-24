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

namespace Seminar
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        static int i = 0;

        private void navUri_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                Movies movie = new Movies();
                this.NavigationService.Navigate(movie);
            }
            else
            {
                System.Windows.MessageBox.Show("Continue your voting on the right arrow!");
            }
            i++;
        }
    }
}
