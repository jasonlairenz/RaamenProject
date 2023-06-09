using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RaamenProject.Model;

namespace RaamenProject.Repository
{
    public class UserRepository
    {

        static RaamenDatabaseEntities db = new RaamenDatabaseEntities();


        public static void addUser(User newUser)
        {
            db.Users.Add(newUser);
            db.SaveChanges();
        }

        public static List<User> viewUser()
        {
            return db.Users.ToList<User>();
        }

        public static List<User> viewMember()
        {
            User user = db.Users.FirstOrDefault(data => data.Roleid == 1);
            List<User> userList = new List<User>();

            if (user != null)
            {
                userList.Add(user);
            }

            return userList;
        }

        public static List<User> viewStaff()
        {
            User user = db.Users.FirstOrDefault(data => data.Roleid == 3);
            List<User> userList = new List<User>();

            if (user != null)
            {
                userList.Add(user);
            }

            return userList;
        }

        public static User viewUserById(int id)
        {
            return db.Users.Find(id);
        }

        public static void updateUser(int id, String Username, String Email, String Gender, String Password)
        {
            User user = db.Users.Find(id);
            user.Username = Username;
            user.Email = Email;
            user.Gender = Gender;
            user.Password = Password;
            db.SaveChanges();
        }

        public static void deleteUser(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
        }

        public static User getUser(String Username, String Password)
        {
            User user = (from data in db.Users where data.Username.Equals(Username) && data.Password.Equals(Password) select data).FirstOrDefault();

            return user;
        }

        public static int findUsername(string Username)
        {
            int findUsername = (from data in db.Users where data.Username.Equals(Username) select data.id).FirstOrDefault();
            return findUsername;
        }
    }
}