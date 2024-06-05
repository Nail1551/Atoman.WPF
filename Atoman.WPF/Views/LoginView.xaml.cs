using Atoman.WPF.ViewModels;
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

namespace Atoman.WPF.Views
{
    /// <summary>
    /// Логика взаимодействия для LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        private LoginViewModel _loginviewModel { get; set; }
        public LoginView()
        {
            InitializeComponent();
            _loginviewModel = new LoginViewModel();
            this.DataContext = _loginviewModel;

        }

        public string Login = "Nail";
        public string Password = "Major";

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = logbox.Text;
            string password = pasbox.Password;
            if (username == Login && password == Password)
            {
                MessageBox.Show("Вход выполнен успешно!");
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль. Попробуйте снова.");
            }
        }
    }
}
