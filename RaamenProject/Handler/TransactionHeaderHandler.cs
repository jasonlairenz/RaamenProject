using RaamenProject.Factory;
using RaamenProject.Model;
using RaamenProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaamenProject.Handler
{
    public class TransactionHeaderHandler
    {
        public static void checkout(int customerId, int staffId, int orderNumber, String status)
        {
            Header header = TransactionHeaderFactory.createTransaction(customerId, staffId, orderNumber, status);
            TransactionHeaderRepository.checkout(header);
        }

        public static List<Header> viewTransaction()
        {
            TransactionHeaderRepository data = new TransactionHeaderRepository();
            return data.viewTransaction();
        }

        public static List<Header> viewTransactionById(int UserId)
        {
            return TransactionHeaderRepository.viewTransactionById(UserId);
        }
    }
}