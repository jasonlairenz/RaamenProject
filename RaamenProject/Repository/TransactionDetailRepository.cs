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

        public static List<Detail> listViewDetailById(int id)
        {
            return db.Details.Where(detail => detail.Headerid == id).ToList();
        }
        public static dynamic viewDetailById(int id)
        {
            return db.Details.Join(db.Ramen, detail => detail.Ramenid, ramen => ramen.id, (detail, ramen) => new
            {
                HeaderId = detail.Headerid,
                RamenName = ramen.Name,
                RamenMeat = ramen.Meatid,
                RamenBroth = ramen.Borth,
                RamenPrice = ramen.Price,
                Quantity = detail.Quantity,
            }).Where(detail => detail.HeaderId == id).ToList();
        }
    }
}