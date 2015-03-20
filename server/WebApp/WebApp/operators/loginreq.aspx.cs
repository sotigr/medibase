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
                    string[] q = globals.DBINFO.SEND_QUERY_MULT("SELECT USERID, TITLE, FIRSTNAME, LASTNAME, GENUS, AGE, PROFESSION, EMAIL, PASSWORD, ADDRESS1, ADDRESS2, PHONE, CELLPHONE, TOWN, ZIPCODE, COUNTRY FROM USERS WHERE EMAIL = '" + username + "';");
                    Session["user"] = new classes.user() { id = q[0], title = q[1], firstname = q[2], lastname = q[3], gender = q[4], age = q[5], profession = q[6], email = q[7], password = q[8], address1 = q[9], address2 = q[10], phone = q[11], celphone = q[12], town = q[13], zipcode = q[14], country = q[15] };
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