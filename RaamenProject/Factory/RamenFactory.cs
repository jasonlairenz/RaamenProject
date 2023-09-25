using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RaamenProject.Model;

namespace RaamenProject.Factory
{
    public class RamenFactory
    {
        

        public static Raman createRamen(int Meatid, String Name, String Borth, String Price)
        {
            Raman ramen = new Raman();
            ramen.Meatid = Meatid;
            ramen.Name = Name;
            ramen.Borth = Borth;
            ramen.Price = Price;
            return ramen;
        }


    }
}