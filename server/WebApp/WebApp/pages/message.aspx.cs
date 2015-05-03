using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.pages
{
    public partial class message : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // If the user is not logged or the his title is other than Doctor (Dr),
            // then page will not be displayed or accessible to that user.
            //
            // Papaioannou S.

            if (Session["user"] == null)
            {
                Response.Clear();
                Response.End();
                return;
            }
            if (((classes.user)Session["user"]).title != "Dr")
            {
                Response.Clear();
                Response.End();
            }
        }
    }
}