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
    /// Interaction logic for Movies.xaml
    /// </summary>
    /// 

    public partial class Movies : Page
    {
        public Movies()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public static Boolean BATMAN = false;
        public static Boolean BADBOYS = false;
        public static Boolean DEADPOOL = false;
        public static Boolean INTERSTELLAR = false;
        public static Boolean LORD = false;
        public static Boolean XM = false;
        
        static int i = 0;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                tvShows tv = new tvShows();
                this.NavigationService.Navigate(tv);
            }
            else {
                this.NavigationService.GoForward();
            }
            i++;
        }

        private void Batman_Unchecked(object sender, RoutedEventArgs e)
        {
            bat.Background = Brushes.Gold;
            BATMAN = false;
        }

        private void Badboys_Unchecked(object sender, RoutedEventArgs e)
        {
            bad.Background = Brushes.Gold;
            BADBOYS = false;
        }

        private void Interstellar_Unchecked(object sender, RoutedEventArgs e)
        {
            inter.Background = Brushes.Gold;
            INTERSTELLAR = false;
        }

        private void DeadPool_Unchecked(object sender, RoutedEventArgs e)
        {
            dead.Background = Brushes.Gold;
            DEADPOOL = false;
        }

        private void LOTR_Unchecked(object sender, RoutedEventArgs e)
        {
            lotr.Background = Brushes.Gold;
            LORD = false;
        }

        private void XMEN_Unchecked(object sender, RoutedEventArgs e)
        {
            xmen.Background = Brushes.Gold;
            XM = false;
        }

        private void XMEN_Checked(object sender, RoutedEventArgs e)
        {
            xmen.Background = Brushes.Red;
            XM = true;
        }

        private void LOTR_Checked(object sender, RoutedEventArgs e)
        {
            lotr.Background = Brushes.Red;
            LORD = true;
        }

        private void DeadPool_Checked(object sender, RoutedEventArgs e)
        {
            dead.Background = Brushes.Red;
            DEADPOOL = true;
        }

        private void Interstellar_Checked(object sender, RoutedEventArgs e)
        {
            inter.Background = Brushes.Red;
            INTERSTELLAR = true;
        }

        private void Badboys_Checked(object sender, RoutedEventArgs e)
        {
            bad.Background = Brushes.Red;
            BADBOYS = true;
        }

        private void Batman_Checked(object sender, RoutedEventArgs e)
        {
            bat.Background = Brushes.Red;
            BATMAN = true;
        }
    }
}
