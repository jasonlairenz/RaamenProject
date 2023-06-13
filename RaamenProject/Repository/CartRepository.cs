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

        public static List<Cart> listViewCart(int UserId)
        {
            return db.Carts.Where(cart => cart.UserId == UserId).ToList();
        }

        public static dynamic viewCart(int UserId)
        {
            return db.Carts.Join(db.Ramen, cart => cart.RamenId, ramen => ramen.id, (cart,ramen) => new
            {
                UserId = cart.UserId,
                RamenName = ramen.Name,
                RamenMeat = ramen.Meatid,
                RamenBroth = ramen.Borth,
                RamenPrice = ramen.Price,
                Quantity = cart.Quantity,
            }).Where(cart => cart.UserId == UserId).ToList();
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

        public static int getOrderNumber()
        {
            int orderNumber = (from data in db.Orders where data.OrderId == 1 select data.OrderNumber).FirstOrDefault();
            return orderNumber;
        }

        public static void updateOrderNumber()
        {
            Order order = db.Orders.Find(1);
            order.OrderNumber += 1;
            db.SaveChanges();
        }
    }
}