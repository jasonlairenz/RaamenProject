using RaamenProject.Controller;
using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RaamenProject.View.Transaction
{
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = int.Parse(Request.QueryString["UserId"]);
                User u = UserController.viewUserById(id);

                if (u.Roleid == 1)
                {
                    // member
                    int UserId = int.Parse(Request.QueryString["UserId"]);
                    GridView2.DataSource = TransactionHeaderController.viewTransactionById(UserId);
                    GridView2.DataBind();
                }
                else if (u.Roleid == 2)
                {
                    // admin
                    GridView2.DataSource = TransactionHeaderController.viewTransaction();
                    GridView2.DataBind();
                }
                
            }
        }

        public int getUserRole()
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            User u = UserController.viewUserById(id);
            return u.Roleid;
        }
        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIdx1 = Convert.ToInt32(e.CommandArgument);
            GridViewRow r1 = GridView2.Rows[rowIdx1];
            String headerId = r1.Cells[1].Text;
            


            Response.Redirect("~/View/Transaction/TransactionDetail.aspx?HeaderId="+ headerId);
        }
    }
}