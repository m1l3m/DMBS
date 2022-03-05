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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace WPF_zadaca_2
{
    /// <summary>
    /// Interaction logic for Podesavanja.xaml
    /// </summary>
    public partial class Podesavanja : Window
    {
       

        public Podesavanja()
        {
            InitializeComponent();
        }

        //kada se otvara prozor za podešavanja povlači sačuvane podatke
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtbox_ImeBaze.Text = Properties.Settings.Default.database;
            txtbox_ImeServera.Text = Properties.Settings.Default.server;
            txtbox_Username.Text = Properties.Settings.Default.username;
            passbox_Password.Password = Properties.Settings.Default.password;
        }


        //klikom na dugme odustani zatvara se prozor
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //klikom na dugme sačuvaj uneseni podaci se čuvaju u podešavanja
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.database = txtbox_ImeBaze.Text;
            Properties.Settings.Default.server = txtbox_ImeServera.Text;
            Properties.Settings.Default.username = txtbox_Username.Text;
            Properties.Settings.Default.password = passbox_Password.Password;
            Properties.Settings.Default.Save();
        }


        //pokušava da otvori konekciju na osnovu podešavanja iz polja
        //obavještava da li je uspio ili nije
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            Console.WriteLine("Server=" + txtbox_ImeServera.Text + ";Database=" + txtbox_ImeBaze.Text + ";Uid=" + txtbox_Username.Text + ";Pwd=" + passbox_Password.Password + ";");
            try
            {
                MySqlConnection konekcija = new MySqlConnection("Server=" + txtbox_ImeServera.Text + ";Database=" + txtbox_ImeBaze.Text + ";Uid=" + txtbox_Username.Text + ";Pwd=" + passbox_Password.Password + ";");
                konekcija.Open();
                MessageBox.Show("Konekcija na bazu je ostvarena.","Konekcija",MessageBoxButton.OK,MessageBoxImage.Information);
                konekcija.Close();
            }
            catch
            {
                MessageBox.Show("Nije moguće spojiti se na bazu!","Greška",MessageBoxButton.OK,MessageBoxImage.Error); 
            }
        }




        

      

       
    }
}
