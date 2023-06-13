using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaamenProject.Factory
{
    public class TransactionDetailFactory
    {
        public static Detail createDetail(int headerId, int ramenId, int quantity)
        {
            Detail detail = new Detail();
            detail.Headerid = headerId;
            detail.Ramenid = ramenId;
            detail.Quantity = quantity;
            return detail;
        }
    }
}