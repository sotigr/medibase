using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.operators
{
    public partial class loginreq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request["uname"];
            string password = Request["password"];
            if (username != null && password != null)
            {
                if (username == globals.DBINFO.SEND_QUERY("SELECT EMAIL FROM USERS WHERE PASSWORD = (SELECT PASSWORD FROM USERS WHERE EMAIL ='" + username + "')"))
                {
                    Response.Clear();
                    Response.Write("OK");
                    Response.End();
                }
                else
                {
                    Response.Clear();
                    Response.Write("0");
                    Response.End();
                }
            }
            else
            {
                Response.Clear();
                Response.Write("0");
                Response.End();
            }
        }
    }
}