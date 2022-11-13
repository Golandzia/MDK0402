using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork8.Model;

namespace HomeWork8.Core
{
    public class ReaderUsers
    {
        public async Task<bool> UserWork(string Login, string Password)
        {
            using (StreamReader userReader = new StreamReader(@"..\..\File\User.txt"))
            {
                var userAwait = await userReader.ReadToEndAsync();
                List<User> userList = new List<User>();

                foreach (var item in userAwait.Split('\n'))
                {
                    var arrayString = item.Split('.');
                    {
                        var user = new User()
                        {
                            Login = arrayString[0],
                            Password = arrayString[1],
                        };
                        if (user.Login.Contains(Login) && user.Password.Contains(Password))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }
    }
}
