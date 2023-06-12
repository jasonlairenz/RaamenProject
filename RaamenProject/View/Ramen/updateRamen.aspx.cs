using RaamenProject.Controller;
using RaamenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RaamenProject.View.Ramen
{
    public partial class updateRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int Id = int.Parse(Request.QueryString["RamenId"]);
                Raman m = RamenController.viewRamenById(Id);
                nameTxt.Text = m.Name;
                meatBtn.SelectedValue = m.Meatid.ToString();
                borthTxt.Text = m.Borth;
                priceTxt.Text = m.Price;
            }
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            statusLbl.Text = "";

            String Name = nameTxt.Text;
            int Meat = int.Parse(meatBtn.SelectedValue);
            String Borth = borthTxt.Text;
            String Price = priceTxt.Text;
            int Id = int.Parse(Request.QueryString["RamenId"]);

            statusLbl.Text = RamenController.updateRamen(Id, Meat, Name, Borth, Price);
            if (statusLbl.Text.Equals("Success"))
            {
                Response.Redirect("~/View/Ramen/viewRamen.aspx");
            }
        }
    }
}