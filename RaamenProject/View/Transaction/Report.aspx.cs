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

            TransactionDataSet Data = GetTransaction(TransactionHeaderController.listViewTransaction());
            Report.SetDataSource(Data);
            
        }

        private TransactionDataSet GetTransaction(List<Header> header)
        {
            TransactionDataSet Data = new TransactionDataSet();
            var Table_Header = Data.Header;
            var Table_Detail = Data.Detail;

            foreach (Header i in header)
            {
                var Header_Row = Table_Header.NewRow();
                Header_Row["id"] = i.id;
                Header_Row["CustomerId"] = i.CustomerId;
                Header_Row["Date"] = i.Date;
                Header_Row["Status"] = i.Status;
                

                int total = 0;

                foreach (Detail td in TransactionDetailController.listViewDetailById(i.id))
                {
                    var Detail_Row = Table_Detail.NewRow();
                    Detail_Row["HeaderId"] = td.Headerid;
                    Detail_Row["RamenId"] = td.Ramenid;
                    Detail_Row["Quantity"] = td.Quantity;
                    Detail_Row["RamenName"] = RamenController.viewRamenById(td.Ramenid).Name;
                    Detail_Row["RamenPrice"] = RamenController.viewRamenById(td.Ramenid).Price;
                    total += int.Parse(RamenController.viewRamenById(td.Ramenid).Price) * td.Quantity;
                    Table_Detail.Rows.Add(Detail_Row);
                }
                Header_Row["Total"] = total;
                Table_Header.Rows.Add(Header_Row);
            }
            return Data;
        }
    }
}