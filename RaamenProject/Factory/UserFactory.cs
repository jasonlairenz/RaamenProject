using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RaamenProject.Model; 

namespace RaamenProject.Factory
{
    public class UserFactory
    {
        public static User createUser(String Username, String Email, String Gender, String Password)
        {
            User user = new User();
            user.Username = Username;
            user.Email = Email;
            user.Gender = Gender;
            user.Password = Password;
            user.Roleid = 1;
            return user;
        }
    }
}