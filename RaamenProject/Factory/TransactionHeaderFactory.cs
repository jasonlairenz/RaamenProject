using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaamenProject.Factory
{
    public class TransactionHeaderFactory
    {
        public static Header createTransaction(int customerId, int staffId)
        {
            Header header = new Header();
            header.CustomerId = customerId;
            header.Staffid = 3;
            header.Date = DateTime.Now;
            return header;
        }
    }
}