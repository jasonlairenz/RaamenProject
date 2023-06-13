using RaamenProject.Controller;
using RaamenProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RaamenProject.View.Transaction
{
    public partial class TransactionQueue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GridView2.DataSource = TransactionHeaderController.viewTransaction();
                GridView2.DataBind();
            }
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIdx1 = Convert.ToInt32(e.CommandArgument);
            GridViewRow r1 = GridView2.Rows[rowIdx1];
            int headerId = int.Parse(r1.Cells[1].Text);
            int UserId = int.Parse(Request.QueryString["UserId"]);
            TransactionHeaderRepository.updateStatus(headerId);
            Response.Redirect("~/View/Transaction/TransactionQueue.aspx?UserId="+UserId);
        }

    }
}