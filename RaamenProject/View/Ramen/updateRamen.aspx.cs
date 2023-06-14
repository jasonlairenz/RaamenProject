using RaamenProject.Controller;
using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace RaamenProject.View.Ramen
{
    public partial class updateRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int UserId = int.Parse(Request.QueryString["UserId"]);
                User u = UserController.viewUserById(UserId);

                if (u.Roleid == 1)
                {
                    // member
                    Response.Redirect("~/View/Home.aspx?UserId=" + UserId);
                }
                int Id = int.Parse(Request.QueryString["RamenId"]);
                Raman m = RamenController.viewRamenById(Id);
                nameTxt.Text = m.Name;
                meatBtn.SelectedValue = m.Meatid.ToString();
                borthTxt.Text = m.Borth;
                priceTxt.Text = m.Price;
            }
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

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            statusLbl.Text = "";

               int UserId = int.Parse(Request.QueryString["UserId"]);
            String Name = nameTxt.Text;
            int Meat = int.Parse(meatBtn.SelectedValue);
            String Borth = borthTxt.Text;
            String Price = priceTxt.Text;
            int Id = int.Parse(Request.QueryString["RamenId"]);

            statusLbl.Text = RamenController.updateRamen(Id, Meat, Name, Borth, Price);
            if (statusLbl.Text.Equals("Success"))
            {
                Response.Redirect("~/View/Ramen/viewRamen.aspx?UserId="+UserId);
            }
        }
    }
}