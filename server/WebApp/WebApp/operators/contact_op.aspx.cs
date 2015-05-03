using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.operators
{
    public partial class contact_op : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // The information entered by the user are passed in to variables.
            // As long as these variables are not "null" or empty the message 
            // along with the rest of the information are inserted in the 
            // application's Database.
            // 
            // Karmiris D.

            string Name = Request["c_name"];
            string Email = Request["c_email"];
            string Subject = Request["c_subject"];
            string Comments = Request["c_content"];
            if (Name != "" && Name != null
                && Email != "" && Email != null
                && Subject != "" && Subject != null
                && Comments != "" && Comments != null)
            {
                string query = "INSERT INTO INBOX VALUES (NULL ,'"
                                     + Name + "','"
                                     + Email + "','"
                                     + Subject + "','"
                                     + Comments + "'"
                                     + ");";

                globals.DBINFO.SEND_QUERY(query);
                Respond("1");
                return;
            }
            else
            {
                Respond("0");
            }
        }
        void Respond(string message)
        {
            Response.Clear();
            Response.Write(message);
            Response.End();
        }
    }
}