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
            string login, password, passwordBoxText;

            login = LoginFromUser.Text;
            password = PasswordFromUser.Text;
            passwordBoxText = PasswordBoxFromUser.Password.ToString();

            VerificateUser verificateUser = new VerificateUser();
            bool result = verificateUser.Check(login, password, passwordBoxText);
            if (result == true)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }
    }
}
