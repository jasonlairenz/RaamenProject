using RaamenProject.Handler;
using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace RaamenProject.Controller
{
    public class UserController
    {

        public static String addUser(String Username, String Email, String Gender, String Password, String confirm)
        {
            Regex regexUsername = new Regex(@"^[a-zA-Z]+$");
            Regex regexEmail = new Regex(@"\.com$");
            if (Username.Equals(""))
            {
                return "Username Must fill";
            } else if  (Username.Length < 5 || Username.Length > 15)
                {
                    return "Username Must be between 5-15 characters";
                }
            
            else if (!(regexUsername.IsMatch(Username)))
            {
                return "Username must only contain letters";
            }
            else if (Email.Equals(""))
            {
                return "email must be filled";
            }
            else if (!(regexEmail.IsMatch(Email)))
            {
                return "Email must end with .com";
            } else if (Password.Equals(""))
            {
                return "Password must be filled";
            }
            else if (!(Password.Equals(confirm))){
                return "Password must be the same as confirm password";
            }
            else
            {
                UserHandler.addUser(Username, Email, Gender, Password);
                return "Successfully";
            }
            

        }

        public static List<User> viewUser()
        {
            return UserHandler.viewUser();
        }

        public static User viewUserById(int id)
        {
            return UserHandler.viewUserById(id);
        }

        public static void updateUser(int id, String Username, String Email, String Gender, String Password)
        {
            UserHandler.updateUser(id, Username, Email, Gender, Password);
        }

        public static void deleteUser(int id)
        {
            UserHandler.deleteUser(id);
        }
    }
}