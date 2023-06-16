using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numismatics.Models
{
    public class Users
    {
       
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }

        public Users()
        {
            Id = 0;
            Name = string.Empty;
            Email = string.Empty;
            Login = string.Empty;
            Password = string.Empty;
        }

        public Users(int id, string name, string email, string login, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Login = login;
            Password = password;
        }

        public Users(string name, string email, string login, string password)
        {
            Name = name;
            Email = email;
            Login = login;
            Password = password;
        }

        public Users(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
