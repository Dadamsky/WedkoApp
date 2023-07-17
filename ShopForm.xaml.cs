using System.Windows;

namespace WedkoApp
{
    public partial class ShopForm : Window
    {
        private string username; // przechowuje nazwę użytkownika zalogowanego

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

        private void DodajButton_Click(object sender, RoutedEventArgs e)
        {
            // Kod obsługujący dodawanie produktu
            // Tutaj możesz otworzyć nowe okno lub wykonać inne czynności związane z dodawaniem produktu
        }

        private void EdytujButton_Click(object sender, RoutedEventArgs e)
        {
            // Kod obsługujący edycję produktu
            // Tutaj możesz otworzyć nowe okno lub wykonać inne czynności związane z edycją produktu
        }

        private void UsunButton_Click(object sender, RoutedEventArgs e)
        {
            // Kod obsługujący usuwanie produktu
            // Tutaj możesz otworzyć nowe okno lub wykonać inne czynności związane z usuwaniem produktu
        }

        private void WylogujButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wylogowano użytkownika: " + username);
            // Tutaj możesz zamknąć okno lub wrócić do formularza logowania
        }
    }
}
