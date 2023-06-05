using RaamenProject.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RaamenProject.Model;

namespace RaamenProject.Controller
{
    public class RamenController
    {
        public static void addRamen(int Meatid, String Name, String Borth, String Price)
        {
            RamenHandler.addRamen(Meatid, Name, Borth, Price);
           

        }

        public static List<Raman> viewRamen()
        {
            return RamenHandler.viewRamen();
        }

        public static Raman viewRamenById(int id)
        {
            return RamenHandler.viewRamenById(id);
        }

        public static void updateRamen(int id, int Meatid, String Name, String Borth, String Price)
        {
            RamenHandler.updateRamen(id, Meatid, Name, Borth, Price);
        }

        public static void deleteRamen(int id)
        {
            RamenHandler.deleteRamen(id);
        }
    }
}