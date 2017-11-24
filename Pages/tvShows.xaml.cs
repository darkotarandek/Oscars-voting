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
    /// Interaction logic for tvShows.xaml
    /// </summary>
    public partial class tvShows : Page
    {
        public tvShows()
        {
            InitializeComponent();
        }

        public static Boolean SUPERNATURAL = false;
        public static Boolean WALKING = false;
        public static Boolean THEORY = false;
        public static Boolean ROBOT = false;
        public static Boolean BRBA = false;
        public static Boolean GOTH = false;

        static int i = 0;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                Actresses actress = new Actresses();
                this.NavigationService.Navigate(actress);
            }
            else {
                this.NavigationService.GoForward();
            }
            i++;  
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void Supernatural_Checked(object sender, RoutedEventArgs e)
        {
            spn.Background = Brushes.Blue;
            SUPERNATURAL = true;
        }

        private void Supernatural_Unchecked(object sender, RoutedEventArgs e)
        {
            spn.Background = Brushes.Black;
            SUPERNATURAL = false;
        }

        private void TWD_Checked(object sender, RoutedEventArgs e)
        {
            twd.Background = Brushes.Blue;
            WALKING = true;
        }

        private void TWD_Unchecked(object sender, RoutedEventArgs e)
        {
            twd.Background = Brushes.Black;
            WALKING = false;
        }

        private void TBBT_Checked(object sender, RoutedEventArgs e)
        {
            tbbt.Background = Brushes.Blue;
            THEORY = true;
        }

        private void TBBT_Unchecked(object sender, RoutedEventArgs e)
        {
            tbbt.Background = Brushes.Black;
            THEORY = false;
        }

        private void Robot_Checked(object sender, RoutedEventArgs e)
        {
            robot.Background = Brushes.Blue;
            ROBOT = true;
        }

        private void Robot_Unchecked(object sender, RoutedEventArgs e)
        {
            robot.Background = Brushes.Black;
            ROBOT = false;
        }

        private void Breaking_Checked(object sender, RoutedEventArgs e)
        {
            brba.Background = Brushes.Blue;
            BRBA = true;
        }

        private void Breaking_Unchecked(object sender, RoutedEventArgs e)
        {
            brba.Background = Brushes.Black;
            BRBA = false;
        }

        private void Gotham_Checked(object sender, RoutedEventArgs e)
        {
            gotham.Background = Brushes.Blue;
            GOTH = true;
        }

        private void Gotham_Unchecked(object sender, RoutedEventArgs e)
        {
            gotham.Background = Brushes.Black;
            GOTH = false;
        }

    }
}
