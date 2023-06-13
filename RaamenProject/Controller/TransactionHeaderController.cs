using RaamenProject.Handler;
using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaamenProject.Controller
{
    public class TransactionHeaderController
    {
        public static String checkout(int customerId, int staffId, int orderNumber, String status)
        {

            TransactionHeaderHandler.checkout(customerId, staffId, orderNumber, status);

            return "Success";
        }

        public static List<Header> viewTransaction()
        {
            return TransactionHeaderHandler.viewTransaction();
        }

        public static List<Header> viewTransactionById(int UserId)
        {
            return TransactionHeaderHandler.viewTransactionById(UserId);
        }
    }
}