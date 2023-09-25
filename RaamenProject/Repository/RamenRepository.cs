using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RaamenProject.Model;

namespace RaamenProject.Repository
{
    public class RamenRepository
    {
        static RaamenDatabaseEntities db = new RaamenDatabaseEntities();


        public static void addRamen(Raman newRamen)
        {
            db.Ramen.Add(newRamen);
            db.SaveChanges();
        }
        
        public static List<Raman> viewRamen()
        {
            return db.Ramen.ToList<Raman>();
        }

        public static Raman viewRamenById(int id)
        {
            return db.Ramen.Find(id);
        }

        public static void updateRamen(int id, int Meatid, String Name, String Borth, String Price)
        {
            Raman ramen = db.Ramen.Find(id);
            ramen.Meatid = Meatid;
            ramen.Name = Name;
            ramen.Borth = Borth;
            ramen.Price = Price;
            db.SaveChanges();
        }

        public static void deleteRamen(int id)
        {
            Raman ramen = db.Ramen.Find(id);
            db.Ramen.Remove(ramen);
            db.SaveChanges();
        }

        public static String ramenName(int ramenId)
        {
            String ramenName = (from data in db.Ramen where data.id.Equals(ramenId) select data.Name).FirstOrDefault();
            return ramenName;
        }

    }
}