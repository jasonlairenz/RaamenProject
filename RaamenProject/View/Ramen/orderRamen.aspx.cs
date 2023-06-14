using RaamenProject.Controller;
using RaamenProject.Model;
using RaamenProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace RaamenProject.View.Ramen
{
    public partial class orderRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int UserId = int.Parse(Request.QueryString["UserId"]);
                User u = UserController.viewUserById(UserId);

                if (u.Roleid == 2)
                {
                    // admin
                    Response.Redirect("~/View/Home.aspx?UserId="+UserId);
                }
                else if (u.Roleid == 3)
                {
                    // staff
                    Response.Redirect("~/View/Home.aspx?UserId="+UserId);
                }

                GridView1.DataSource = RamenController.viewRamen();
                GridView1.DataBind();

                GridView2.DataSource = CartController.listViewCart(UserId);
                GridView2.DataBind();
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

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIdx1 = Convert.ToInt32(e.CommandArgument);
            GridViewRow r1 = GridView1.Rows[rowIdx1];
            String ramenId = r1.Cells[1].Text;

            int RamenId = int.Parse(ramenId);
            int Quantity = int.Parse(quantityTxt.Text);

            int UserId = int.Parse(Request.QueryString["UserId"]);

            bool cartItemExists = CartController.checkCart(UserId, RamenId);

            if (cartItemExists)
            {
                int rowIdx2 = Convert.ToInt32(e.CommandArgument);
                GridViewRow r2 = GridView2.Rows[rowIdx2];
                int CartId = int.Parse(r2.Cells[1].Text);
                CartController.updateCart(CartId, UserId, RamenId, Quantity);
            }
            else
            {
                int orderId = CartController.getOrderNumber();
                CartController.addToCart(UserId, RamenId, Quantity, orderId);
            }
            Response.Redirect("~/View/Ramen/orderRamen.aspx?UserId=" + UserId);
        }

        protected void GridView2_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            int UserId = int.Parse(Request.QueryString["UserId"]);
            GridViewRow r = GridView2.Rows[e.RowIndex];
            String CartId = r.Cells[1].Text;

            CartController.deleteCartById(int.Parse(CartId));

            Response.Redirect("~/View/Ramen/orderRamen.aspx?UserId=" + UserId);
        }

        protected void clearCartBtn_Click(object sender, EventArgs e)
        {
            int UserId = int.Parse(Request.QueryString["UserId"]);
            CartController.deleteCartAll(UserId);

            Response.Redirect("~/View/Ramen/orderRamen.aspx?UserId=" + UserId);
        }

        protected void buyBtn_Click(object sender, EventArgs e)
        {
            int staffId = 3;
            int UserId = int.Parse(Request.QueryString["UserId"]);
            int orderId = CartController.getOrderNumber();
            String status = "Pending";
            statusLbl.Text = TransactionHeaderController.checkout(UserId, staffId, orderId, status );
            

            int headerId = TransactionHeaderRepository.findHeaderId(orderId);

            foreach (GridViewRow row in GridView2.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    int ramenId = int.Parse(row.Cells[3].Text);
                    int quantity = int.Parse(row.Cells[4].Text);

                    TransactionDetailController.addDetail(headerId, ramenId, quantity);
                }
            }

            CartController.deleteCartAll(UserId);
            CartController.updateOrderNumber();
            if (statusLbl.Text.Equals("Success"))
            { 
                Response.Redirect("~/View/Transaction/History.aspx?UserId=" + UserId);
            }
        }
    }
}