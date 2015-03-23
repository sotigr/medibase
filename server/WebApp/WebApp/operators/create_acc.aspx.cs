using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.operators
{
    public partial class create_acc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Title = Request["s_title"];
            string Name = Request["s_name"];
            if (Title != "" && Name != "")
            {
                //query einai lathos to query alla paradigma einai.
                try
                {
                    globals.DBINFO.SEND_QUERY("INSERT INTO USERS VALUES ''");
                    Respond("1");
                } 
                catch {
                    Respond("0");
                }

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