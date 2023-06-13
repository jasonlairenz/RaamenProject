using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaamenProject.Repository
{
    public class TransactionDetailRepository
    {
        static RaamenDatabaseEntities db = new RaamenDatabaseEntities();
        public static void addDetail(Detail newDetail)
        {
            db.Details.Add(newDetail);
            db.SaveChanges();
        }
        public static List<Detail> viewDetailById(int id)
        {
            return db.Details.Where(detail => detail.Headerid == id).ToList();
        }
    }
}