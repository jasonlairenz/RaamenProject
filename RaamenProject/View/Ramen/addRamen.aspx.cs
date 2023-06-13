using RaamenProject.Controller;
using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RaamenProject.View
{
    public partial class addRamen : System.Web.UI.Page
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
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            statusLbl.Text = "";

            String Name = nameTxt.Text;
            int Meat = int.Parse(meatBtn.SelectedValue);
            String Borth = borthTxt.Text;
            String Price = priceTxt.Text;

            int UserId = int.Parse(Request.QueryString["UserId"]);

            statusLbl.Text =  RamenController.addRamen(Meat, Name, Borth, Price);
            if (statusLbl.Text.Equals("Success"))
            {
                Response.Redirect("~/View/Ramen/viewRamen.aspx?UserId="+UserId);
            }
        }
    }
}