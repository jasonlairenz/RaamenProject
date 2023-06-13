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

        public static List<Header> listViewTransaction()
        {
            return TransactionHeaderRepository.listViewTransaction();
        }

        public static dynamic viewTransaction()
        {
            return TransactionHeaderRepository.viewTransaction();
        }

        public static List<Header> listViewTransactionById(int UserId)
        {
            return TransactionHeaderRepository.listViewTransactionById(UserId);
        }

        public static dynamic viewTransactionById(int UserId)
        {
            return TransactionHeaderRepository.viewTransactionById(UserId);
        }
    }
}