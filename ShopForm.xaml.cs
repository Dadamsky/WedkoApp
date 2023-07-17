using System.Windows;

namespace WedkoApp
{
    public partial class ShopForm : Window
    {
        private string username; // przechowuje nazwę użytkownika zalogowanego
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\fishShopDB.mdf;Integrated Security=True";

        public ShopForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void PrzegladajButton_Click(object sender, RoutedEventArgs e)
        {
            // Kod obsługujący przeglądanie produktów
            // Tutaj możesz otworzyć nowe okno lub wykonać inne czynności związane z przeglądaniem produktów
        }

        private void WylogujButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wylogowano użytkownika: " + username);
            // Tutaj możesz zamknąć okno lub wrócić do formularza logowania
        }
    }
}
