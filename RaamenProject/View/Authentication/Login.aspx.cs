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
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            String Username = usernameTxt.Text;
            String Password = passTxt.Text;

            statusLbl.Text = UserController.login(Username, Password);

            if (statusLbl.Text.Equals("Success"))
            {
                int Id = UserController.findUsername(Username);
                Response.Redirect("~/View/Home.aspx?UserId=" + Id);
            }
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Authentication/Register.aspx");
        }
    }
}