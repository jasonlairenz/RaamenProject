using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaamenProject.Factory
{
    public class CartFactory
    {
        public static Cart createCart(int UserId, int RamenId, int Quantity, int OrderNumber)
        {
            Cart cart = new Cart();
            cart.UserId = UserId;
            cart.RamenId = RamenId;
            cart.Quantity = Quantity;
            cart.OrderId = OrderNumber;
            return cart;
        }
    }
}