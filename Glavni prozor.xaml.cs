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
using MySql.Data.MySqlClient;
using System.Data;

namespace WPF_zadaca_2
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

        //klikom na labelu za podešavanja konekcije otvara se prozor za podešavanje konekcije
        //kad se zatvara prozor za podešavanja pokusaće da update-uje datagrid iz baze koja je sačuvana u podešavanjima
        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Podesavanja podesavanja = new Podesavanja();
            podesavanja.Closing += podesavanja_Closing;
            podesavanja.ShowDialog();
            
        }

        //poziva funkciju ucitaj() kada se otvara prozor
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ucitaj();

        }


        //klikom na dugme poništi čisti polja i postavlja fokus na textbox u koji se unosi username
        //možda je trebalo ime biti btn_Ponisti?
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtbox_Ime.Text = "";
            txtbox_Prezime.Text = "";
            txtbox_username.Text = "";
            passbox_password.Password = "";
            txtbox_username.Focus();
        }

        //klikom na dugme snimi
        //ako su uneseni svi podaci
        //pokušava da otvori konekciju na bazu koja je sačuvana u podešavanjima
        //ako uspije
        //preko NonQuery komande "cmd" obavlja dodavanje u bazu
        //čisti polja
        //postavlja fokus na username
        //obavještava da je uspio
        //osvježava sadržaj datagrida
        //zatvara konekciju
        //ako ne uspije izbacuje grešku
        //ako nisu popunjena sva polja obavještava da treba da se popune sva polja
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtbox_Ime.Text != "" && txtbox_Prezime.Text != "" && txtbox_username.Text != "" && passbox_password.Password != "")
            {
                try
                {
                    MySqlConnection konekcija = new MySqlConnection("Server=" + Properties.Settings.Default.server + ";Database=" + Properties.Settings.Default.database + ";Uid=" + Properties.Settings.Default.username + ";Pwd=" + Properties.Settings.Default.password.ToString() + ";");
                    konekcija.Open();
                    string sql = "INSERT INTO `korisnici` (`id`, `username`, `password`, `ime`, `prezime`) VALUES (NULL, '" + txtbox_username.Text.ToString() + "', PASSWORD('" + passbox_password.Password.ToString() + "'), '" + txtbox_Ime.Text.ToString() + "', '" + txtbox_Prezime.Text.ToString() + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, konekcija);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Podaci uspješno snimljeni!","Obavještenje",MessageBoxButton.OK,MessageBoxImage.Information);
                    txtbox_Ime.Text = "";
                    txtbox_Prezime.Text = "";
                    txtbox_username.Text = "";
                    passbox_password.Password = "";
                    txtbox_username.Focus();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `korisnici`", konekcija);
                    da.Fill(dt);
                    datagrid.ItemsSource = dt.DefaultView;
                    konekcija.Close();
                }
                catch
                {
                    MessageBox.Show("Nije moguće spojiti se na bazu!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Unesite sve podatke!", "Pažnja", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                txtbox_username.Focus();
            }
        }

       
        //pokušava da ostvari konekciju sa bazom
        //ako uspije popunjava datagrid
        //zatim zatvara konekciju i postavlja fokus na username
        //izbacuje poruku o konekciji
        //ako ne uspije obavještava da je došlo do greške i čisti datagrid
        private void ucitaj()
        {
            try
            {
                MySqlConnection konekcija = new MySqlConnection("Server=" + Properties.Settings.Default.server + ";Database=" + Properties.Settings.Default.database + ";Uid=" + Properties.Settings.Default.username + ";Pwd=" + Properties.Settings.Default.password.ToString() + ";");
                konekcija.Open();
                Console.WriteLine(konekcija.ToString());
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `korisnici`", konekcija);
                da.Fill(dt);
                datagrid.ItemsSource = dt.DefaultView;
                konekcija.Close();
                txtbox_username.Focus();
                MessageBox.Show("Konekcija na bazu je ostvarena.", "Konekcija", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Nije moguće spojiti se na bazu!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                datagrid.ItemsSource = "";
            }
 
        }

        //kada se zatvaraju podešavanja
        //ovo je urađeno da bi osvježio datagrid svaki put kad se zatvore podešavanja
        //ako se promijeni baza on prikazuje odgovarajući sadržaj
        //ako su podaci pogrešni i ne može da se ostvari konekcija onda jednostavno čisti datagrid
        //prikazuje odgovarajuće poruke
        //pogledati iznad funkciju ucitaj()
        private void podesavanja_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ucitaj();

        }
        
    }
}
