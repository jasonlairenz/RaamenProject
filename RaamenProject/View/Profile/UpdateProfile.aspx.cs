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
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = int.Parse(Request.QueryString["UserId"]);
                User u = UserController.viewUserById(id);
                usernameTxt.Text = u.Username;
                emailTxt.Text = u.Email;
                genderBtn.Text = u.Gender;
                passTxt.Text = u.Password;
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            statusLbl.Text = "";

            int Id = int.Parse(Request.QueryString["UserId"]);
            String Username = usernameTxt.Text;
            String Email = emailTxt.Text;
            String Gender = genderBtn.SelectedValue.ToString();
            String Password = passTxt.Text;

            statusLbl.Text = UserController.updateUser(Id, Username, Email, Gender, Password);

            if (statusLbl.Text.Equals("insert successfully"))
            {
                Response.Redirect("~/View/Profile/ViewProfile.aspx");
            }
        }
    }
}