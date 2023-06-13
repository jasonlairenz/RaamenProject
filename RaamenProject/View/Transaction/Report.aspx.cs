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
            var THeader = Data.Header;
            var TDetail = Data.Detail;

            foreach (Header i in header)
            {
                var HRow = THeader.NewRow();
                HRow["id"] = i.id;
                HRow["CustomerId"] = i.CustomerId;
                HRow["Date"] = i.Date;
                HRow["Status"] = i.Status;
                

                int total = 0;

                foreach (Detail td in TransactionDetailController.listViewDetailById(i.id))
                {
                    var DRow = TDetail.NewRow();
                    DRow["HeaderId"] = td.Headerid;
                    DRow["RamenId"] = td.Ramenid;
                    DRow["Quantity"] = td.Quantity;
                    DRow["RamenName"] = RamenController.viewRamenById(td.Ramenid).Name;
                    DRow["RamenPrice"] = RamenController.viewRamenById(td.Ramenid).Price;
                    total += int.Parse(RamenController.viewRamenById(td.Ramenid).Price) * td.Quantity;
                    TDetail.Rows.Add(DRow);
                }
                HRow["Total"] = total;
                THeader.Rows.Add(HRow);
            }
            return Data;
        }
    }
}