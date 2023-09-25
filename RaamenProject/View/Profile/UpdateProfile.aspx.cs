﻿using RaamenProject.Controller;
using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

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

        public int getUserRole()
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            User u = UserController.viewUserById(id);
            return u.Roleid;
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

            Response.Redirect("~/View/Authentication/Login.aspx");
        }

        protected void profileBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            Response.Redirect("~/View/Profile/ViewProfile.aspx?UserId=" + id);
        }

        protected void orderRamenBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            Response.Redirect("~/View/Ramen/orderRamen.aspx?UserId=" + id);
        }

        protected void orderQueueBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            Response.Redirect("~/View/Transaction/TransactionQueue.aspx?UserId=" + id);
        }

        protected void manageRamenBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            Response.Redirect("~/View/Ramen/viewRamen.aspx?UserId=" + id);
        }

        protected void historyBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            Response.Redirect("~/View/Transaction/History.aspx?UserId=" + id);
        }

        protected void reportBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            Response.Redirect("~/View/Transaction/Report.aspx?UserId=" + id);
        }



        protected void homeBtn_Click1(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UserId"]);
            Response.Redirect("~/View/Home.aspx?UserId=" + id);
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
                Response.Redirect("~/View/Profile/ViewProfile.aspx?UserId="+Id);
            }
        }
    }
}