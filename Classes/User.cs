using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToursApp
{
    internal class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public static string Name { get; set; }

        public static User[] GetUsers()
        {
            return new User[]
            {
                new User() { Login="Админ", Password="Админ"},
                new User() { Login="Менеджер", Password="Менеджер"}
            };
        }
        public static bool CheckLogin(string login)
        {
            for (int i= 0; i < GetUsers().Length; i++)
            {
                if (login == GetUsers()[i].Login)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckPassword(string login, string password)
        {
            int indexUser = 0;
            for (int i = 0; i < GetUsers().Length; i++)
            {
                if (login == GetUsers()[i].Login)
                {
                    indexUser = i;
                    break;
                }
            }
            if (password == GetUsers()[indexUser].Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
