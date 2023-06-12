using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaamenProject.Repository
{
    public class CartRepository
    {
        static RaamenDatabaseEntities db = new RaamenDatabaseEntities();
        public static void addToCart(Cart newCart)
        {
            db.Carts.Add(newCart);
            db.SaveChanges();
        }

        public static void updateCart(int CartId, int UserId, int RamenId, int Quantity)
        {
            Cart cart = db.Carts.Find(CartId);
            cart.UserId = UserId;
            cart.RamenId = RamenId;
            cart.Quantity += 1;
            db.SaveChanges();
        }

        public static List<Cart> viewCart()
        {
            return db.Carts.ToList<Cart>();
        }

        //public static void deleteCartAll(int id, int UserId, int RamenId)
        //{
        //    User user = db.Users.Find(id);

        //    int cart = (from data in db.Carts where data.UserId.Equals(UserId) && data.RamenId.Equals(RamenId) select data.CartId).FirstOrDefault();

        //    Cart cartId = db.Carts.Find(cart);

        //    db.Carts.Remove(cartId);
        //    db.SaveChanges();
        //}

        public static void deleteCartById(int id)
        {
            Cart cart = db.Carts.Find(id);
            db.Carts.Remove(cart);
            db.SaveChanges();
        }
        public static bool checkCart(int userId, int ramenId)
        {
            return db.Carts.Any(cart => cart.UserId == userId && cart.RamenId == ramenId);
        }
    }
}