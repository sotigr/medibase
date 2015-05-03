using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if the user is logged in.
            // If yes, then the client can receive some information about the user.
            // If not, the variables will be returned empty.
            //
            //Papaioannou S.

            if (Session["user"] != null)
            {
                js_session_vars.Controls.Add(new LiteralControl("<script>"
                    + "var loggedin = true;"
                    + "var username = '" + ((classes.user)Session["user"]).firstname + "';"
                    + "var usertitle = '" + ((classes.user)Session["user"]).title + "';"
                    + "</script>"));
            }
            else
            {
                js_session_vars.Controls.Add(new LiteralControl("<script>"
                    + "var loggedin = false;"
                    + "var username = '';"
                     + "var usertitle = '';"
                    + "</script>"));
            }
        }
    }
}