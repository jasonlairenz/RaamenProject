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
        public static void checkout(int customerId, int staffId)
        {
            Header header = TransactionHeaderFactory.createTransaction(customerId, staffId);
            TransactionHeaderRepository.checkout(header);
        }

        public static List<Header> viewTransaction()
        {
            return TransactionHeaderRepository.viewTransaction();
        }

        public static List<Header> viewTransactionById(int UserId)
        {
            return TransactionHeaderRepository.viewTransactionById(UserId);
        }
    }
}