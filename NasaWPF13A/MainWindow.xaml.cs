using NASACLI13A;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NasaWPF13A
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMinden_Click(object sender, RoutedEventArgs e)
        {
            Program.Beolvas("NASAmissions.txt");
            dtgAdatok.ItemsSource = Program.kuldetesek;
        }

        private void dtgAdatok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbStatisztika.Content = Program.kuldetesek[dtgAdatok.SelectedIndex].Nev;
            pgbErtek.Value = Program.kuldetesek[dtgAdatok.SelectedIndex].HasznosTeher;
        }

    }
}