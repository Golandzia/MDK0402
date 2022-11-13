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
using AuthorizationWindow.Core;

namespace HomeWork4.Front
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            if (user.CheckingUser(LoginFromUser.Text, PasswordFromUser.Text))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login or password", "Authorization", MessageBoxButton.OK, MessageBoxImage.Warning);
                LoginFromUser.Text = "";
                PasswordFromUser.Text = "";
            }
        }
    }
}
