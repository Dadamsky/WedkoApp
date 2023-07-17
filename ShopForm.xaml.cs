using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WedkoApp.Models;

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
            using (YourDatabaseContext dbContext = new YourDatabaseContext())
            {
                List<Product> products = dbContext.Products.ToList();
                listBoxProducts.ItemsSource = products;
            }
        }

        private void WylogujButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wylogowano użytkownika: " + username);
            // Tutaj możesz zamknąć okno lub wrócić do formularza logowania
        }
    }
}
