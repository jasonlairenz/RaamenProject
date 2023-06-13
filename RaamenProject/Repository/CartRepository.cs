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
            cart.Quantity += Quantity;
            db.SaveChanges();
        }

        public static List<Cart> viewCart()
        {
            return db.Carts.ToList<Cart>();
        }

        public static void deleteCartAll(int UserId)
        {
            var items = db.Carts.Where(cart => cart.UserId == UserId).ToList();
            db.Carts.RemoveRange(items);
            db.SaveChanges();
        }

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