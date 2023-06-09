using RaamenProject.Controller;
using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RaamenProject.View.Profile
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            User u = UserController.viewUserById(id);
            usernameLbl.Text = u.Username;
            emailLbl.Text = u.Email;
            genderLbl.Text = u.Gender;
            passLbl.Text = u.Password;
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/View/Profile/Update.aspx?UserId=" + id);
        }
    }
}