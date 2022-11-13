using HomeWork8.Core;
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

namespace HomeWork8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            ReaderUsers reader = new ReaderUsers();
            var result = await reader.UserWork(LoginFromUser.Text, PasswordFromUser.Text);
            if (LoginFromUser.Text != "" && PasswordFromUser.Text != "")
            {
                if (result == true)
                {
                    MessageBox.Show("Вход выполнен");
                }
                else MessageBox.Show("Неверный логин или пароль");
            }
            else MessageBox.Show("Не все поля заполнены");
        }
    }
}
