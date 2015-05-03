using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

namespace WebApp.operators
{
    public partial class msg_list_op : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // If the user is not logged in then the page will not be accessible.
            // Otherwise, the list of the page will be filled with the appropriate infoarmation
            // and display all the amssages this user has received.
            //
            // Papaioannou S.

            if (Session["user"] == null)
            {
                Response.Clear();
                Response.End();
                return;
            }
            else
            {
                string query = "SELECT MESSID, SENDER, DATEOFMESSAGE, SUBJECT, MESSAGE FROM messaging where RECIPIENT = '" + ((classes.user)Session["user"]).email + "';";

                IDictionary<int, IDictionary<string, string>> q = globals.DBINFO.SEND_QUERY_MULT_DICT_MULT(query);
                List<List<string>> ls = new List<List<string>>();

                Response.Clear();
                Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(q));
                Response.End();
            }
        }
    }
}