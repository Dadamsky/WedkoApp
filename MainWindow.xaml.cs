using System.Windows;

namespace WedkoApp
{
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
            // Sprawdź, czy dane logowania są poprawne

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Logowanie pomyślne!");

                ShopForm shopForm = new ShopForm(username);
                shopForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane logowania!");
            }
        }
    }
}
