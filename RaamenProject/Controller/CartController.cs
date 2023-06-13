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
        public static void addToCart( int UserId, int RamenId, int Quantity, int orderId)
        {
            CartHandler.addToCart( UserId, RamenId, Quantity, orderId);
            //return "Success"
        }
        public static void updateCart(int CartId, int UserId, int RamenId, int Quantity)
        {
            CartHandler.updateCart(CartId, UserId, RamenId, Quantity);
        }

        public static List<Cart> listViewCart(int UserId)
        {
            return CartHandler.listViewCart(UserId);
        }

        public static dynamic viewCart(int UserId)
        {
            return CartHandler.viewCart(UserId);
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

        public static int getOrderNumber()
        {
            return CartHandler.getOrderNumber();
        }

        public static void updateOrderNumber()
        {
            CartHandler.updateOrderNumber();
        }

    }
}