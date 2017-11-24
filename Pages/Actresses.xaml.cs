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
    /// Interaction logic for Actresses.xaml
    /// </summary>
    public partial class Actresses : Page
    {
        public Actresses()
        {
            InitializeComponent();
        }

        public static Boolean AJOLIE = false;
        public static Boolean JLAWRENCE = false;
        public static Boolean ESTONE = false;
        public static Boolean JANISTON = false;
        public static Boolean MKUNIS = false;
        public static Boolean ANNEH = false;

        static int i = 0;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                Actors actor = new Actors();
                this.NavigationService.Navigate(actor);
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

        private void AJ_Checked(object sender, RoutedEventArgs e)
        {
            angelina.Background = Brushes.LimeGreen;
            AJOLIE = true;
        }

        private void AJ_Unchecked(object sender, RoutedEventArgs e)
        {
            angelina.Background = Brushes.LightCoral;
            AJOLIE = false;
        }

        private void JL_Checked(object sender, RoutedEventArgs e)
        {
            lawrence.Background = Brushes.LimeGreen;
            JLAWRENCE = true;
        }

        private void JL_Unchecked(object sender, RoutedEventArgs e)
        {
            lawrence.Background = Brushes.LightCoral;
            JLAWRENCE = false;
        }

        private void ES_Checked(object sender, RoutedEventArgs e)
        {
            emma.Background = Brushes.LimeGreen;
            ESTONE = true;
        }

        private void ES_Unchecked(object sender, RoutedEventArgs e)
        {
            emma.Background = Brushes.LightCoral;
            ESTONE = false;
        }

        private void JA_Checked(object sender, RoutedEventArgs e)
        {
            aniston.Background = Brushes.LimeGreen;
            JANISTON = true;
        }

        private void JA_Unchecked(object sender, RoutedEventArgs e)
        {
            aniston.Background = Brushes.LightCoral;
            JANISTON = false;
        }

        private void MK_Checked(object sender, RoutedEventArgs e)
        {
            mila.Background = Brushes.LimeGreen;
            MKUNIS = true;
        }

        private void MK_Unchecked(object sender, RoutedEventArgs e)
        {
            mila.Background = Brushes.LightCoral;
            MKUNIS = false;
        }

        private void AH_Checked(object sender, RoutedEventArgs e)
        {
            anne.Background = Brushes.LimeGreen;
            ANNEH = true;
        }

        private void AH_Unchecked(object sender, RoutedEventArgs e)
        {
            anne.Background = Brushes.LightCoral;
            ANNEH = false;
        }
    }
}
