using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.operators
{
    public partial class message_op : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Recipient = Request["m_recipient"];
            string Subject = Request["m_subject"];
            string Content = Request["m_content"];
            if (Recipient != "" && Recipient != null
                && Subject != "" && Subject != null
                && Content != "" && Content != null)
            {

                string query = "INSERT INTO MESSAGING VALUES (NULL ,'"
                                     + Recipient + "','"
                                     + ((classes.user)Session["user"]).firstname + " " + ((classes.user)Session["user"]).lastname + "','"
                                     + DateTime.Now.ToString("yyyy-MM-dd") + "','"
                                     + Subject + "','"
                                     + Content + "'"
                                     + ");";

                globals.DBINFO.SEND_QUERY(query);
                Respond("1");
                return;
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