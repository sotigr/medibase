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
            string command = Request["com"];
            if (command != null)
            {
                if (command == "logout")
                {
                    Session["user"] = null;
                    Session.Abandon();
                    Respond("1");
                    return;
                }
            }
            if (username != null && password != null)
            {
                if (password == globals.DBINFO.SEND_QUERY("SELECT PASSWORD FROM USERS WHERE EMAIL = '" + username + "';"))
                {
                    string[] q = globals.DBINFO.SEND_QUERY_MULT("SELECT  NAME, LASTNAME, USERNAME, PASSWORD, EMAIL, ADDRESS1, ADDRESS2, PHONE, CELLPHONE,DATEOFBIRTH FROM USERS WHERE EMAIL = '" + username + "';");
                    Session["user"] = new classes.user() { FirstName = q[0], LastName = q[1], UserName = q[2], Password = q[3], Email = q[4], Address1 = q[5], Address2 = q[6], Phone = q[7], Cellphone = q[8], DateOfBirth = Convert.ToDateTime(q[9]) };
                    // Console.WriteLine(((classes.user)Session["user"]).DateOfBirth.ToString("dd-MM-yyyy"));
                    Respond("1");
                    return;
                }
                else
                {
                    Respond("0");
                    return;
                }
            }

        }
        public void Respond(string message)
        {
            Response.Clear();
            Response.Write(message);
            Response.End();
        }
    }
}