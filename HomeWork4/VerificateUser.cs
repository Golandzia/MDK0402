using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HomeWork4
{
    public class VerificateUser
    {

        public string Login { get; set; }
        public string Password { get; set; }


        public static ObservableCollection<VerificateUser> GetUsersList()
        {

            var userList = new ObservableCollection<VerificateUser>()
            {
                new VerificateUser() { Login = "Daniil", Password = "qwerty" },
            };

            return userList;
        }


        public bool Check(string login, string password, string passwordBoxText)
        {
            if (login != "" && (password != "" || passwordBoxText != ""))
            {
                foreach (var user in GetUsersList())
                {
                    if (user.Login == login && (user.Password == password || user.Password == passwordBoxText))
                    {
                        MessageBox.Show("Вход выполнен успешно", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Stop);
                        return false;
                    }
                }
            }
            else MessageBox.Show("Не все поля заполнены!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Stop);
            return false;
        }
    }
}
