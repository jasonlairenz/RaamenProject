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
    public partial class TransactionDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int UserId = int.Parse(Request.QueryString["UserId"]);
                User u = UserController.viewUserById(UserId);

                if (u.Roleid == 3)
                {
                    // staff
                    Response.Redirect("~/View/Home.aspx?UserId=" + UserId);
                }

                int HeaderId = int.Parse(Request.QueryString["HeaderId"]);
                GridView2.DataSource = TransactionDetailController.viewDetailById(HeaderId);
                GridView2.DataBind();
            }
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}