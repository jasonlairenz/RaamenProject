using RaamenProject.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RaamenProject.Model;
using System.Text.RegularExpressions;

namespace RaamenProject.Controller
{
    public class RamenController
    {
        public static String addRamen(int Meatid, String Name, String Borth, String Price)
        {
            if (Name.Equals(""))
            {
                return "Name Must be filled";
            }

            else if (!(Name.Contains("Ramen")))
            {
                return "Username must contain 'Ramen'";
            }
            else if (Borth.Equals(""))
            {
                return "Borth must be filled";
            }
            else if (Price.Equals(""))
            {
                return "Price must be filled";
            }
            else if (int.Parse(Price) < 3000)
            {
                return "Price must be at least 3000";
            }
            else
            {
                RamenHandler.addRamen(Meatid, Name, Borth, Price);
                return "Success";
            }
        }

        internal static List<Raman> GetAllRamen()
        {
            throw new NotImplementedException();
        }

        public static List<Raman> viewRamen()
        {
            return RamenHandler.viewRamen();
        }

        public static Raman viewRamenById(int id)
        {
            return RamenHandler.viewRamenById(id);
        }

        public static String updateRamen(int id, int Meatid, String Name, String Borth, String Price)
        {
            if (Name.Equals(""))
            {
                return "Name Must be filled";
            }

            else if (!(Name.Contains("Ramen")))
            {
                return "Username must contain 'Ramen'";
            }
            else if (Borth.Equals(""))
            {
                return "Borth must be filled";
            }
            else if (Price.Equals(""))
            {
                return "Price must be filled";
            }
            else if (int.Parse(Price) < 3000)
            {
                return "Price must be at least 3000";
            }
            else
            {
                RamenHandler.updateRamen(id, Meatid, Name, Borth, Price);
                return "Success";
            }
        }

        public static void deleteRamen(int id)
        {
            RamenHandler.deleteRamen(id);
        }

        public static String ramenName(int RamenId)
        {
            return RamenHandler.ramenName(RamenId);
        }
    }
}