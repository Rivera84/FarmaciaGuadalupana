using System.Windows;

namespace FarmaciaGuadalupana
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Salir(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Ingresar(object sender, RoutedEventArgs e)
        {
            MenuPrincipal.Menu menu = new MenuPrincipal.Menu();
            this.Hide();
            menu.Show();
        }
    }
}
