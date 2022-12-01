using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebRegisterLogin.Models;

namespace WebRegisterLogin.lib
{
    public class UserLib
    {
        public static bool Login(string username, string password)
        {
            
            UserModel userToLogin = UserDAL.GetUserByUsername(username);
            if (userToLogin == null) return false;

            if (!Hasher.Verify(password, userToLogin.password)) return false;
            return true;
        }

        public static bool Register(string username, string password, string firstName, string lastName)
        {
            if (DoesUserExist(username)) return false;

            bool successfullyRegistered = UserDAL.AddUser(username, Hasher.Hash(password), firstName, lastName);

            return successfullyRegistered;
        }

        public static bool DoesUserExist(string username)
        {
            return UserDAL.GetUserByUsername(username) != null;
        }
    }
}