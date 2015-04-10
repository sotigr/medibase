using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.pages
{
    public partial class edit_acc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                classes.user usr = (classes.user)Session["user"];
                pl1.Controls.Add(new LiteralControl("<script>var title = '" + usr.title + "';"
                    + "var name = '" + usr.firstname + "';"
                    + "var surname = '" + usr.lastname + "';"
                    + "var gender = '" + usr.gender + "';"
                    + "var age = '" + usr.age + "';"
                    + "var email = '" + usr.email + "';"
                    + "var profession = '" + usr.profession + "';"
                    + "var address1 = '" + usr.address1 + "';"
                    + "var zip = '" + usr.zipcode + "';"
                    + "var phone = '" + usr.phone + "';"
                    + "var celphone = '" + usr.celphone + "';"
                    + "var town = '" + usr.town + "';"
                    + "var country = '" + usr.country + "';"
                    + "</script>"));
            }
            else
            {
                Respond("");
            }

        }
        public void Respond(string message)
        {
            Response.Clear();
            Response.Write(message);
            Response.End();
        }
    }
}