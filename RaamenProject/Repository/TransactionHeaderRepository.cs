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

        public static List<Header> listViewTransaction()
        {
            return db.Headers.ToList();
        }

        public static dynamic viewTransaction()
        {
            return db.Headers.Join(db.Users, header => header.CustomerId, user => user.id, (header, user) => new
            {
                OrderId = header.OrderId,
                CustomerName = user.Username,
                Date = header.Date,
                StaffId = header.Staffid,
                Status = header.Status,
            }).ToList();
        }

        public static List<Header> listViewTransactionById(int UserId)
        {
            return db.Headers.Where(cart => cart.CustomerId == UserId).ToList();
        }

        public static dynamic viewTransactionById(int UserId)
        {
            return db.Headers.Join(db.Users, header => header.CustomerId, user => user.id, (header, user) => new
            {
                OrderId = header.OrderId,
                CustomerId = header.CustomerId,
                CustomerName = user.Username,
                Date = header.Date,
                StaffId = header.Staffid,
                Status = header.Status,
            }).Where(cart => cart.CustomerId == UserId).ToList();
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