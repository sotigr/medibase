using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.operators
{
    public partial class delete_msg : System.Web.UI.Page
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
            else
            {
                string msgid = Request["mid"];
                if (msgid == null) return;
                globals.DBINFO.SEND_QUERY("DELETE FROM messaging WHERE MESSID = '" + msgid + "' AND RECIPIENT = '" + ((classes.user)Session["user"]).email + "'");

                Response.Clear();
                Response.Write("1");
                Response.End();
            }
        }
    }
}