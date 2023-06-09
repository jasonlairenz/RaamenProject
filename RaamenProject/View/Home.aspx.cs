using RaamenProject.Controller;
using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace RaamenProject.View
{
    public partial class Home : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = int.Parse(Request.QueryString["UserId"]);
                User u = UserController.viewUserById(id);
                //usernameLbl.Text = u.Username;
                //emailLbl.Text = u.Email;
                //genderLbl.Text = u.Gender;

                if (u.Roleid == 1)
                {
                    roleLbl.Text = "Member";
                }
                else if (u.Roleid == 2)
                {
                    roleLbl.Text = "Admin";
                    GridViewStaff.DataSource = UserController.viewStaff();
                    GridViewStaff.DataBind();

                    GridViewMemberr.DataSource = UserController.viewMember();
                    GridViewMemberr.DataBind();
                }
                else if (u.Roleid == 3)
                {
                    roleLbl.Text = "Staff";
                    GridViewMember.DataSource = UserController.viewMember();
                    GridViewMember.DataBind();
                }
            }
        }

        public int getUserRole()
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            User u = UserController.viewUserById(id);
            return u.Roleid;
        }

        public User getStaffData()
        {
            User u = UserController.viewUserById(2);
            return u;
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

            Response.Redirect("~/View/Login.aspx");
        }

        protected void profileBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            Response.Redirect("~/View/Profile/ViewProfile.aspx?UserId="+id);
        }
    }
}