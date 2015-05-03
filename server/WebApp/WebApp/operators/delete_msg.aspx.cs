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
            
            // If the user is logged in a request for the ID of the message is requested from the Database and passed into the variable "msgid".
            // The Message with the same ID as "msgid" and "email" as the logged in user is being deleted.
            //
            // Papaioannou S.

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