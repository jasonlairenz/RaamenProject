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
        public static void addToCart( int UserId, int RamenId, int Quantity, int orderId)
        {
            Cart cart = CartFactory.createCart( UserId, RamenId, Quantity, orderId);
            CartRepository.addToCart(cart);
        }

        public static void updateCart(int CartId, int UserId, int RamenId, int Quantity)
        {
            CartRepository.updateCart(CartId, UserId, RamenId, Quantity);
        }

        public static List<Cart> listViewCart(int UserId)
        {
           return CartRepository.listViewCart(UserId);
        }

        public static dynamic viewCart(int UserId)
        {
            return CartRepository.viewCart(UserId);
        }

        public static void deleteCartById(int id)
        {
           CartRepository.deleteCartById(id);
        }

        public static void deleteCartAll(int UserId)
        {
            CartRepository.deleteCartAll(UserId);
        }

        public static bool checkCart(int userId, int ramenId)
        {
            return CartRepository.checkCart(userId,ramenId);
        }

        public static int getOrderNumber()
        {
            return CartRepository.getOrderNumber();
        }

        public static void updateOrderNumber()
        {
            CartRepository.updateOrderNumber();
        }

    }
}