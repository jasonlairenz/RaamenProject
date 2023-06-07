using RaamenProject.Controller;
using RaamenProject.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RaamenProject.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            String Username = usernameTxt.Text;
            String Email = emailTxt.Text;
            String Gender = genderBtn.SelectedValue.ToString();
            String Password = passTxt.Text;
            String Confirm = confirmTxt.Text;

            statusLbl.Text = UserController.addUser(Username, Email, Gender, Password, Confirm);
           
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Login.aspx");
        }
    }
}