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

namespace WedkoApp
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

        private void ZalogujButton_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Kod do weryfikacji danych logowania
            // Możesz porównać wartości username i password z wartościami w bazie danych lub innym źródle

            if (username == "admin" && password == "admin")
            {
                // Jeśli dane logowania są prawidłowe, możesz przejść do innej części aplikacji
                MessageBox.Show("Logowanie pomyślne!");
                // Tutaj możesz otworzyć inne okno lub wykonać inne czynności po zalogowaniu
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane logowania!");
            }
        }
    }
}
