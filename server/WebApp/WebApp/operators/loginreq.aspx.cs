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
                    IDictionary<string, string> q = globals.DBINFO.SEND_QUERY_MULT_DICT("SELECT USERID, TITLE, FIRSTNAME, LASTNAME, GENUS, AGE, PROFESSION, EMAIL, PASSWORD, ADDRESS1, ADDRESS2, PHONE, CELLPHONE, TOWN, ZIPCODE, COUNTRY FROM USERS WHERE EMAIL = '" + username + "';");

                    Session["user"] = new classes.user() {
                        id = q["USERID"],
                        title = q["TITLE"],
                        firstname = q["FIRSTNAME"],
                        lastname = q["LASTNAME"],
                        gender = q["GENUS"],
                        age = q["AGE"],
                        profession = q["PROFESSION"],
                        email = q["EMAIL"],
                        password = q["PASSWORD"],
                        address1 = q["ADDRESS1"],
                        address2 = q["ADDRESS2"],
                        phone = q["PHONE"],
                        celphone = q["CELLPHONE"],
                        town = q["TOWN"],
                        zipcode = q["ZIPCODE"],
                        country = q["COUNTRY"]
                    };

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