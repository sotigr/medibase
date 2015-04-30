using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.pages
{
    public partial class message_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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