using RaamenProject.Factory;
using RaamenProject.Model;
using RaamenProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaamenProject.Handler
{
    public class CartHandler
    {
        public static void addToCart( int UserId, int RamenId, int Quantity)
        {
            Cart cart = CartFactory.createCart( UserId, RamenId, Quantity);
            CartRepository.addToCart(cart);
        }

        public static void updateCart(int CartId, int UserId, int RamenId, int Quantity)
        {
            CartRepository.updateCart(CartId, UserId, RamenId, Quantity);
        }

        public static List<Cart> viewCart()
        {
            return CartRepository.viewCart();
        }

        public static void deleteCartById(int id)
        {
           CartRepository.deleteCartById(id);
        }
        public static bool checkCart(int userId, int ramenId)
        {
            return CartRepository.checkCart(userId,ramenId);
        }
    }
}