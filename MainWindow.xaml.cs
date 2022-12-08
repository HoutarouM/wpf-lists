using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace liste
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IEnumerable<string> StringCollection { get; set; }
        public ObservableCollection<Film> Films { get; set; }

        public Film CheckedFilm { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            StringCollection = "Ala ma kota Ala ma kota Ala ma kota Ala ma kota Ala ma kota Ala ma kota Ala ma kota Ala ma kota".Split(' ').ToList();
            DataContext = this;

            prepareFilms();

            CheckedFilm = Films[0];
        }

        private void prepareFilms()
        {
            Films = new ObservableCollection<Film>();

            Films.Add(new Film("Vaiana", 6, "film", "animation"));
            Films.Add(new Film("Kraina Lodu", 4, "film", "animation"));
            Films.Add(new Film("Toys story", 6, "film", "animation"));
            Films.Add(new Film("Avatar", 6, "film", "sci-fi"));
        }


        public void Show(object s, RoutedEventArgs e)
        {
            MessageBox.Show(CheckedFilm.Title);
        }

        private void addFilm(object sender, RoutedEventArgs e)
        {
            Films.Add(new Film(nazwa.Text, int.Parse(score.Text), desc.Text, genre.Text));
        }
    }
}
