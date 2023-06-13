using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaamenProject.Repository
{
    public class TransactionHeaderRepository
    {
        static RaamenDatabaseEntities db = new RaamenDatabaseEntities();
        public static void checkout(Header newHeader)
        {
            db.Headers.Add(newHeader);
            db.SaveChanges();
        }

        public  List<Header> viewTransaction()
        {
            return db.Headers.ToList();
        }

        public static List<Header> viewTransactionById(int UserId)
        {
            return db.Headers.Where(cart => cart.CustomerId == UserId).ToList();
        }

        public static int findHeaderId(int orderId)
        {
            int headerId = (from data in db.Headers where data.OrderId == orderId select data.id).FirstOrDefault();
            return headerId;
        }

        public static void updateStatus(int headerId)
        {
            
            Header header = db.Headers.Find(headerId);
            header.Status = "Accepted";
            db.SaveChanges();
        }
    }
}