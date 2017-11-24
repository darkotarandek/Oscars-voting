using System;
using Seminar.Controls;
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
    /// Interaction logic for Page5.xaml
    /// </summary>
    public partial class End : Page
    {

        public End()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((String)lista.SelectedItem == "Batman vs Superman")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/batman.jpg", UriKind.Relative));
                title.Visibility = Visibility.Visible;
                IMDB.Visibility = Visibility.Visible;
                IMDB.Content = "7.1";
            }
            if ((String)lista.SelectedItem == "Bad Boys")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/badBoys.jpg", UriKind.Relative));
                title.Visibility = Visibility.Visible;
                IMDB.Visibility = Visibility.Visible;
                IMDB.Content = "6.8";
            }
            if ((String)lista.SelectedItem == "Deadpool")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/deadpool.jpg", UriKind.Relative));
                title.Visibility = Visibility.Visible;
                IMDB.Visibility = Visibility.Visible;
                IMDB.Content = "8.2";
            }
            if ((String)lista.SelectedItem == "Interstellar")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/interstellar.jpg", UriKind.Relative));
                title.Visibility = Visibility.Visible;
                IMDB.Visibility = Visibility.Visible;
                IMDB.Content = "8.6";
            }
            if ((String)lista.SelectedItem == "Lord of the Rings")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/lotr.jpg", UriKind.Relative));
                title.Visibility = Visibility.Visible;
                IMDB.Visibility = Visibility.Visible;
                IMDB.Content = "8.8";
            }
            if ((String)lista.SelectedItem == "X-Men Apocalypse")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/xmen.jpg", UriKind.Relative));
                title.Visibility = Visibility.Visible;
                IMDB.Visibility = Visibility.Visible;
                IMDB.Content = "7.6";
            }
            if ((String)lista.SelectedItem == "Supernatural")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/supernatural.jpg", UriKind.Relative));
                title.Visibility = Visibility.Visible;
                IMDB.Visibility = Visibility.Visible;
                IMDB.Content = "8.6";
            }
            if ((String)lista.SelectedItem == "The Walking Dead")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/twd.jpg", UriKind.Relative));
                title.Visibility = Visibility.Visible;
                IMDB.Visibility = Visibility.Visible;
                IMDB.Content = "8.6";
            }
            if ((String)lista.SelectedItem == "The Big Bang Theory")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/tbbt.jpg", UriKind.Relative));
                title.Visibility = Visibility.Visible;
                IMDB.Visibility = Visibility.Visible;
                IMDB.Content = "8.4";
            }
            if ((String)lista.SelectedItem == "Mr. Robot")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/mrRobot.jpg", UriKind.Relative));
                title.Visibility = Visibility.Visible;
                IMDB.Visibility = Visibility.Visible;
                IMDB.Content = "8.8";
            }
            if ((String)lista.SelectedItem == "Breaking Bad")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/brba.jpg", UriKind.Relative));
                title.Visibility = Visibility.Visible;
                IMDB.Visibility = Visibility.Visible;
                IMDB.Content = "9.5";
            }
            if ((String)lista.SelectedItem == "Gotham")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/gotham.jpg", UriKind.Relative));
                title.Visibility = Visibility.Visible;
                IMDB.Visibility = Visibility.Visible;
                IMDB.Content = "8.0";
            }
            if ((String)lista.SelectedItem == "Angelina Jolie")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/aj.jpg", UriKind.Relative));
                title.Visibility = Visibility.Hidden;
                IMDB.Visibility = Visibility.Hidden;
            }
            if ((String)lista.SelectedItem == "Jennifer Lawrence")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/jl.jpg", UriKind.Relative));
                title.Visibility = Visibility.Hidden;
                IMDB.Visibility = Visibility.Hidden;
            }
            if ((String)lista.SelectedItem == "Emma Stone")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/es.jpg", UriKind.Relative));
                title.Visibility = Visibility.Hidden;
                IMDB.Visibility = Visibility.Hidden;
            }
            if ((String)lista.SelectedItem == "Jennifer Aniston")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/ja.jpg", UriKind.Relative));
                title.Visibility = Visibility.Hidden;
                IMDB.Visibility = Visibility.Hidden;
            }
            if ((String)lista.SelectedItem == "Mila Kunis")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/mk.jpg", UriKind.Relative));
                title.Visibility = Visibility.Hidden;
                IMDB.Visibility = Visibility.Hidden;
            }
            if ((String)lista.SelectedItem == "Anne Hathaway")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/ah.jpg", UriKind.Relative));
                title.Visibility = Visibility.Hidden;
                IMDB.Visibility = Visibility.Hidden;
            }
            if ((String)lista.SelectedItem == "Brad Pitt")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/bp.jpg", UriKind.Relative));
                title.Visibility = Visibility.Hidden;
                IMDB.Visibility = Visibility.Hidden;
            }
            if ((String)lista.SelectedItem == "Matt Damon")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/md.jpg", UriKind.Relative));
                title.Visibility = Visibility.Hidden;
                IMDB.Visibility = Visibility.Hidden;
            }
            if ((String)lista.SelectedItem == "Jason Statham")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/js.jpg", UriKind.Relative));
                title.Visibility = Visibility.Hidden;
                IMDB.Visibility = Visibility.Hidden;
            }
            if ((String)lista.SelectedItem == "Kevin Hart")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/kh.jpg", UriKind.Relative));
                title.Visibility = Visibility.Hidden;
                IMDB.Visibility = Visibility.Hidden;
            }
            if ((String)lista.SelectedItem == "Will Smith")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/ws.jpg", UriKind.Relative));
                title.Visibility = Visibility.Hidden;
                IMDB.Visibility = Visibility.Hidden;
            }
            if ((String)lista.SelectedItem == "Harrison Ford")
            {
                Slika.Source = new BitmapImage(new Uri("/Images/hf.jpg", UriKind.Relative));
                title.Visibility = Visibility.Hidden;
                IMDB.Visibility = Visibility.Hidden;
            }
        }

        private void lista_Loaded(object sender, RoutedEventArgs e)
        {
            // FILMOVI
            if (Seminar.Movies.BATMAN == true)
            {
                if (!lista.Items.Contains("Batman vs Superman"))
                    lista.Items.Add("Batman vs Superman");
            }
            else
            {
                lista.Items.Remove("Batman vs Superman");
            }
            if (Seminar.Movies.DEADPOOL == true)
            {
                if (!lista.Items.Contains("Deadpool"))
                    lista.Items.Add("Deadpool");
            }
            else
            {
                lista.Items.Remove("Deadpool");
            }
            if (Seminar.Movies.INTERSTELLAR == true)
            {
                if (!lista.Items.Contains("Interstellar"))
                    lista.Items.Add("Interstellar");
            }
            else
            {
                lista.Items.Remove("Interstellar");
            }
            if (Seminar.Movies.LORD == true)
            {
                if (!lista.Items.Contains("Lord of the Rings"))
                    lista.Items.Add("Lord of the Rings");
            }
            else
            {
                lista.Items.Remove("Lord of the Rings");
            }
            if (Seminar.Movies.XM == true)
            {
                if (!lista.Items.Contains("X-Men Apocalypse"))
                    lista.Items.Add("X-Men Apocalypse");
            }
            else
            {
                lista.Items.Remove("X-Men Apocalypse");
            }
            if (Seminar.Movies.BADBOYS == true)
            {
                if (!lista.Items.Contains("Bad Boys"))
                    lista.Items.Add("Bad Boys");
            }
            else
            {
                lista.Items.Remove("Bad Boys");
            }
            // TV SHOWS
            if (Seminar.tvShows.SUPERNATURAL == true)
            {
                if (!lista.Items.Contains("Supernatural"))
                    lista.Items.Add("Supernatural");
            }
            else
            {
                lista.Items.Remove("Supernatural");
            }
            if (Seminar.tvShows.WALKING == true)
            {
                if (!lista.Items.Contains("The Walking Dead"))
                    lista.Items.Add("The Walking Dead");
            }
            else
            {
                lista.Items.Remove("The Walking Dead");
            }
            if (Seminar.tvShows.THEORY == true)
            {
                if (!lista.Items.Contains("The Big Bang Theory"))
                    lista.Items.Add("The Big Bang Theory");
            }
            else
            {
                lista.Items.Remove("The Big Bang Theory");
            }
            if (Seminar.tvShows.ROBOT == true)
            {
                if (!lista.Items.Contains("Mr. Robot"))
                    lista.Items.Add("Mr. Robot");
            }
            else
            {
                lista.Items.Remove("Mr. Robot");
            }
            if (Seminar.tvShows.BRBA == true)
            {
                if (!lista.Items.Contains("Breaking Bad"))
                    lista.Items.Add("Breaking Bad");
            }
            else
            {
                lista.Items.Remove("Breaking Bad");
            }
            if (Seminar.tvShows.GOTH == true)
            {
                if (!lista.Items.Contains("Gotham"))
                    lista.Items.Add("Gotham");
            }
            else
            {
                lista.Items.Remove("Gotham");
            }
            // ACTRESSES
            if (Seminar.Actresses.AJOLIE == true)
            {
                if (!lista.Items.Contains("Angelina Jolie"))
                    lista.Items.Add("Angelina Jolie");
            }
            else
            {
                lista.Items.Remove("Angelina Jolie");
            }
            if (Seminar.Actresses.JLAWRENCE == true)
            {
                if (!lista.Items.Contains("Jennifer Lawrence"))
                    lista.Items.Add("Jennifer Lawrence");
            }
            else
            {
                lista.Items.Remove("Jennifer Lawrence");
            }
            if (Seminar.Actresses.ESTONE == true)
            {
                if (!lista.Items.Contains("Emma Stone"))
                    lista.Items.Add("Emma Stone");
            }
            else
            {
                lista.Items.Remove("Emma Stone");
            }
            if (Seminar.Actresses.JANISTON == true)
            {
                if (!lista.Items.Contains("Jennifer Aniston"))
                    lista.Items.Add("Jennifer Aniston");
            }
            else
            {
                lista.Items.Remove("Jennifer Aniston");
            }
            if (Seminar.Actresses.MKUNIS == true)
            {
                if (!lista.Items.Contains("Mila Kunis"))
                    lista.Items.Add("Mila Kunis");
            }
            else
            {
                lista.Items.Remove("Mila Kunis");
            }
            if (Seminar.Actresses.ANNEH == true)
            {
                if (!lista.Items.Contains("Anne Hathaway"))
                    lista.Items.Add("Anne Hathaway");
            }
            else
            {
                lista.Items.Remove("Anne Hathaway");
            }
            // ACTORS
            if (Seminar.Actors.BPITT == true)
            {
                if (!lista.Items.Contains("Brad Pitt"))
                    lista.Items.Add("Brad Pitt");
            }
            else
            {
                lista.Items.Remove("Brad Pitt");
            }
            if (Seminar.Actors.MDAMON == true)
            {
                if (!lista.Items.Contains("Matt Damon"))
                    lista.Items.Add("Matt Damon");
            }
            else
            {
                lista.Items.Remove("Matt Damon");
            }
            if (Seminar.Actors.JSTATHAM == true)
            {
                if (!lista.Items.Contains("Jason Statham"))
                    lista.Items.Add("Jason Statham");
            }
            else
            {
                lista.Items.Remove("Jason Statham");
            }
            if (Seminar.Actors.KHART == true)
            {
                if (!lista.Items.Contains("Kevin Hart"))
                    lista.Items.Add("Kevin Hart");
            }
            else
            {
                lista.Items.Remove("Kevin Hart");
            }
            if (Seminar.Actors.WSMITH == true)
            {
                if (!lista.Items.Contains("Will Smith"))
                    lista.Items.Add("Will Smith");
            }
            else
            {
                lista.Items.Remove("Will Smith");
            }
            if (Seminar.Actors.HFORD == true)
            {
                if (!lista.Items.Contains("Harrison Ford"))
                    lista.Items.Add("Harrison Ford");
            }
            else
            {
                lista.Items.Remove("Harrison Ford");
            }
        }

    }
}
