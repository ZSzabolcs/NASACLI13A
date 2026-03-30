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
            if (dtgAdatok.SelectedIndex > -1)
            {
                lbStatisztika.Content = Program.kuldetesek[dtgAdatok.SelectedIndex].Nev;
                pgbErtek.Value = Program.kuldetesek[dtgAdatok.SelectedIndex].HasznosTeher;
            }
        }

        private void btnStatisztika_Click(object sender, RoutedEventArgs e)
        {
            lbStatisztika.Content = "Statisztika";
            List<Statisztika> statisztikalista = new List<Statisztika>();
            List<Kuldetes> statisztikalistaEmber = Program.kuldetesek.Where(x => x.Legenyseg > 0).ToList();
            List<Kuldetes> statisztikalistaEmbertelen = Program.kuldetesek.Where(x => x.Legenyseg == 0).ToList();
            statisztikalista.Add(new Statisztika("Emberes küldetések", statisztikalistaEmber.Count, $"{statisztikalistaEmber.Average(x => x.HasznosTeher):F2}  kg", $"{statisztikalistaEmber.Average(x => x.Koltseg):F2} mrd USD$"));

            statisztikalista.Add(new Statisztika("Emberes küldetések", statisztikalistaEmbertelen.Count, $"{statisztikalistaEmbertelen.Average(x => x.HasznosTeher):F2} kg", $"{statisztikalistaEmbertelen.Average(x => x.Koltseg):F2}  mrd USD$"));
            dtgAdatok.ItemsSource = statisztikalista;


        }
    }
}