using RaamenProject.Handler;
using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaamenProject.Controller
{
    public class TransactionDetailController
    {
        public static void addDetail(int headerId, int ramenId, int quantity)
        {
            TransactionDetailHandler.addDetail(headerId, ramenId, quantity);
        }

        public static List<Detail> listViewDetailById(int id)
        {
            return TransactionDetailHandler.listViewDetailById(id);
        }

        public static dynamic viewDetailById(int id)
        {
            return TransactionDetailHandler.viewDetailById(id);
        }
    }
}