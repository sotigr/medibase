using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.pages
{
    public partial class profilecreation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // If the user is logged in the the profile creation page will not be displayed.
            //
            // Karmiris D.

            if (Session["user"] != null)
            {
                Response.Clear();
                Response.Write("403 Forbidden");
                Response.End();
            }
        }
    }
}