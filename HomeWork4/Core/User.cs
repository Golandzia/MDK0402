using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationWindow.Core
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public User() { }

        public static ObservableCollection<User> GetUserList()
        {
            var userList = new ObservableCollection<User>()
            {
                new User()
                {
                    Login = "sysadmin",
                    Password = "1234"
                },
                new User()
                {
                    Login = "admin",
                    Password = "5678"
                }
            };
            return userList;
        }
        public bool CheckingUser(string login, string password)
        {
            foreach(var user in GetUserList())
            {
                if(user.Login == login && user.Password == password)
                    return true;
            }
            return false;
        }
    }
}
