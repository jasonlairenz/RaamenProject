using RaamenProject.Controller;
using RaamenProject.Dataset;
using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace RaamenProject.View.Transaction
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int UserId = int.Parse(Request.QueryString["UserId"]);
            User u = UserController.viewUserById(UserId);

            if (u.Roleid == 1)
            {
                // member
                Response.Redirect("~/View/Home.aspx?UserId=" + UserId);
            }
            else if (u.Roleid == 3)
            {
                // staff
                Response.Redirect("~/View/Home.aspx?UserId=" + UserId);
            }

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

        public int getUserRole()
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            User u = UserController.viewUserById(id);
            return u.Roleid;
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Abandon();

            HttpCookie autkuki = new HttpCookie(FormsAuthentication.FormsCookieName, "");
            autkuki.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(autkuki);

            HttpCookie kuki = new HttpCookie("Nama Kuki", "");
            kuki.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(kuki);

            Response.Redirect("~/View/Authentication/Login.aspx");
        }

        protected void profileBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            Response.Redirect("~/View/Profile/ViewProfile.aspx?UserId=" + id);
        }

        protected void orderRamenBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            Response.Redirect("~/View/Ramen/orderRamen.aspx?UserId=" + id);
        }

        protected void orderQueueBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            Response.Redirect("~/View/Transaction/TransactionQueue.aspx?UserId=" + id);
        }

        protected void manageRamenBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            Response.Redirect("~/View/Ramen/viewRamen.aspx?UserId=" + id);
        }

        protected void historyBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            Response.Redirect("~/View/Transaction/History.aspx?UserId=" + id);
        }

        protected void reportBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            Response.Redirect("~/View/Transaction/Report.aspx?UserId=" + id);
        }

        protected void homeBtn_Click1(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            Response.Redirect("~/View/Home.aspx?UserId=" + id);
        }
    }
}