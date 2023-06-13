using RaamenProject.Factory;
using RaamenProject.Model;
using RaamenProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaamenProject.Handler
{
    public class TransactionDetailHandler
    {
        public static void addDetail(int headerId, int ramenId, int quantity)
        {
            Detail detail = TransactionDetailFactory.createDetail(headerId, ramenId, quantity);
            TransactionDetailRepository.addDetail(detail);
        }

        public static List<Detail> listViewDetailById(int id)
        {
            return TransactionDetailRepository.listViewDetailById(id);
        }

        public static dynamic viewDetailById(int id)
        {
            return TransactionDetailRepository.viewDetailById(id);
        }
    }
}