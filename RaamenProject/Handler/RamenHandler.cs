using RaamenProject.Factory;
using RaamenProject.Model;
using RaamenProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaamenProject.Handler
{
    public class RamenHandler
    {
        public static void addRamen(int Meatid, String Name, String Borth, String Price)
        {
            Raman ramen = RamenFactory.createRamen(Meatid, Name, Borth, Price);
            RamenRepository.addRamen(ramen);

        }

        public static List<Raman> viewRamen()
        {
            return RamenRepository.viewRamen();
        }

        public static Raman viewRamenById(int id)
        {
            return RamenRepository.viewRamenById(id);
        }

        public static void updateRamen(int id, int Meatid, String Name, String Borth, String Price)
        {
            RamenRepository.updateRamen(id, Meatid, Name, Borth, Price);
        }

        public static void deleteRamen(int id)
        {
            RamenRepository.deleteRamen(id);
        }

        public static String ramenName(int RamenId)
        {
            return RamenRepository.ramenName(RamenId);
        }

    }
}