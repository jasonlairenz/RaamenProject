using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RaamenProject.Model;
using RaamenProject.Repository;
using RaamenProject.Factory;

namespace RaamenProject.Handler
{
    public class UserHandler
    {
        public static void addUser(String Username, String Email, String Gender, String Password)
        {
            User user = UserFactory.createUser( Username,  Email, Gender, Password);
            UserRepository.addUser(user);

        }

        public static List<User> viewUser()
        {
            return UserRepository.viewUser();
        }

        public static User viewUserById(int id)
        {
            return UserRepository.viewUserById(id);
        }

        public static void updateUser(int id, String Username, String Email, String Gender, String Password)
        {
            UserRepository.updateUser(id, Username, Email, Gender, Password);
        }

        public static void deleteUser(int id)
        {
            UserRepository.deleteUser(id);
        }
    }
}