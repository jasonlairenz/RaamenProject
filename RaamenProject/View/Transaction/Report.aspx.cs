using RaamenProject.Controller;
using RaamenProject.Dataset;
using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RaamenProject.View.Transaction
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TransactionReport Report = new TransactionReport();
            CrystalReportViewer1.ReportSource = Report;

            TransactionData Data = GetTransaction(TransactionHeaderController.viewTransaction());
            Report.SetDataSource(Data);
            
        }

        private TransactionData GetTransaction(List<Header> header)
        {
            TransactionData Data = new TransactionData();
            var Table_Header = Data.Header;
            var Table_Detail = Data.Detail;

            foreach (Header i in header)
            {
                var Header_Row = Table_Header.NewRow();
                Header_Row["id"] = i.id;
                Header_Row["CustomerId"] = i.CustomerId;
                Header_Row["Date"] = i.Date;
                Header_Row["Status"] = i.Status;
                Table_Header.Rows.Add(Header_Row);

                //foreach (Detail td in i)
                //{
                //    var Detail_Row = Table_Detail.NewRow();
                //    Detail_Row["HeaderId"] = td.Headerid;
                //    Detail_Row["RamenId"] = td.Ramenid;
                //    Detail_Row["Quantity"] = td.Quantity;
                //    Table_Detail.Rows.Add(Detail_Row);
                //}
            }
            return Data;
        }
    }
}