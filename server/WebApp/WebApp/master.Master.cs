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
            if (Session["user"] != null)
            {
              string d=  ((classes.user)Session["user"]).dateofbirth.ToString("dd/MM/yyyy");
              Console.WriteLine(d);
                js_session_vars.Controls.Add(new LiteralControl("<script>"
                    + "var loggedin = true;"
                    + "var username = '" + ((classes.user)Session["user"]).firstname  + "'" 
                    + "</script>"));
            }
            else
            {
                js_session_vars.Controls.Add(new LiteralControl("<script>"
                    + "var loggedin = false;"
                    + "var username = ''"
                    + "</script>"));
            }
        }
    }
}