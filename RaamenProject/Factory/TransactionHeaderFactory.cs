using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaamenProject.Factory
{
    public class TransactionHeaderFactory
    {
        public static Header createTransaction(int customerId, int staffId, int orderId, String status)
        {
            Header header = new Header();
            header.CustomerId = customerId;
            header.Staffid = 3;
            header.Date = DateTime.Now;
            header.OrderId = orderId;
            header.Status = status;
            return header;
        }
    }
}