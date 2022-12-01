using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRegisterLogin.Models
{
    public class UserModel
    {
        public string username;
        public string password;
        public string register_date;
        public int id;
        public string firstName;
        public string lastName;

        public UserModel(string username, string password, string register_date, int id, string firstName, string lastName)
        {
            this.username = username;
            this.password = password;
            this.register_date = register_date;
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}