using RaamenProject.Controller;
using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RaamenProject.View.Ramen
{
    public partial class orderRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GridView1.DataSource = RamenController.viewRamen();
                GridView1.DataBind();

                GridView2.DataSource = CartController.viewCart();
                GridView2.DataBind();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIdx1 = Convert.ToInt32(e.CommandArgument);
            GridViewRow r1 = GridView1.Rows[rowIdx1];
            String ramenId = r1.Cells[2].Text;

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
                CartController.addToCart(UserId, RamenId, Quantity);
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
    }
}