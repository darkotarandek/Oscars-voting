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
    /// Interaction logic for Actors.xaml
    /// </summary>
    public partial class Actors : Page
    {
        public Actors()
        {
            InitializeComponent();
        }

        public static Boolean BPITT = false;
        public static Boolean MDAMON = false;
        public static Boolean JSTATHAM = false;
        public static Boolean KHART = false;
        public static Boolean WSMITH = false;
        public static Boolean HFORD = false;

        static int i = 0;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                End end = new End();
                this.NavigationService.Navigate(end);
            }
            else
            {
                this.NavigationService.GoForward();
            }
            i++;  
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void BP_Checked(object sender, RoutedEventArgs e)
        {
            brad.Background = Brushes.Beige;
            BPITT = true;
        }

        private void BP_Unchecked(object sender, RoutedEventArgs e)
        {
            brad.Background = Brushes.Gold;
            BPITT = false;
        }

        private void MD_Checked(object sender, RoutedEventArgs e)
        {
            matt.Background = Brushes.Beige;
            MDAMON = true;
        }

        private void MD_Unchecked(object sender, RoutedEventArgs e)
        {
            matt.Background = Brushes.Gold;
            MDAMON = false;
        }

        private void JS_Checked(object sender, RoutedEventArgs e)
        {
            jason.Background = Brushes.Beige;
            JSTATHAM = true;
        }

        private void JS_Unchecked(object sender, RoutedEventArgs e)
        {
            jason.Background = Brushes.Gold;
            JSTATHAM = false;
        }

        private void KH_Checked(object sender, RoutedEventArgs e)
        {
            kevin.Background = Brushes.Beige;
            KHART = true;
        }

        private void KH_Unchecked(object sender, RoutedEventArgs e)
        {
            kevin.Background = Brushes.Gold;
            KHART = false;
        }

        private void WS_Checked(object sender, RoutedEventArgs e)
        {
            will.Background = Brushes.Beige;
            WSMITH = true;
        }

        private void WS_Unchecked(object sender, RoutedEventArgs e)
        {
            will.Background = Brushes.Gold;
            WSMITH = false;
        }

        private void HF_Checked(object sender, RoutedEventArgs e)
        {
            ford.Background = Brushes.Beige;
            HFORD = true;
        }

        private void HF_Unchecked(object sender, RoutedEventArgs e)
        {
            ford.Background = Brushes.Gold;
            HFORD = false;
        }
    }
}
