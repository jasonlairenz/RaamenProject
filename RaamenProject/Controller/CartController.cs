using RaamenProject.Handler;
using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaamenProject.Controller
{
    public class CartController
    {
        public static void addToCart( int UserId, int RamenId, int Quantity)
        {
            CartHandler.addToCart( UserId, RamenId, Quantity);
            //return "Success"
        }
        public static void updateCart(int CartId, int UserId, int RamenId, int Quantity)
        {
            CartHandler.updateCart(CartId, UserId, RamenId, Quantity);
        }

        public static List<Cart> viewCart()
        {
            return CartHandler.viewCart();
        }

        public static void deleteCartById(int id)
        {
            CartHandler.deleteCartById(id);
        }

        public static void deleteCartAll(int UserId)
        {
            CartHandler.deleteCartAll(UserId);
        }

        public static bool CheckCartItemExists(int userId, int ramenId)
        {
            using (RaamenDatabaseEntities db = new RaamenDatabaseEntities())
            {
                return db.Carts.Any(c => c.UserId == userId && c.RamenId == ramenId);
            }
        }

        public static bool checkCart(int userId, int ramenId)
        {
            return CartHandler.checkCart(userId, ramenId);
        }

    }
}