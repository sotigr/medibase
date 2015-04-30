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
                IDictionary<string, string> q;
                bool loggedwithcode = false;
                if (password == globals.DBINFO.SEND_QUERY("SELECT PASSWORD FROM USERS WHERE EMAIL = '" + username + "';"))
                {
                    q = globals.DBINFO.SEND_QUERY_MULT_DICT("SELECT USERID, TITLE, MASTERKEY, FIRSTNAME, LASTNAME, GENDER, DATEOFBIRTH, PROFESSION, EMAIL, PASSWORD, ADDRESS1, PHONE, CELLPHONE, TOWN, ZIPCODE, COUNTRY FROM USERS WHERE EMAIL = '" + username + "';");
                }
                else if (password == globals.DBINFO.SEND_QUERY("SELECT PASSWORD FROM USERS WHERE MASTERKEY = '" + username + "';"))
                {
                    loggedwithcode = true;
                    q = globals.DBINFO.SEND_QUERY_MULT_DICT("SELECT USERID, TITLE, MASTERKEY, FIRSTNAME, LASTNAME, GENDER, DATEOFBIRTH, PROFESSION, EMAIL, PASSWORD, ADDRESS1, PHONE, CELLPHONE, TOWN, ZIPCODE, COUNTRY FROM USERS WHERE MASTERKEY = '" + username + "';");
                }
                else
                {
                    Respond("0");
                    return;
                }
                Session["user"] = new classes.user()
                {
                    id = q["USERID"],
                    title = q["TITLE"],
                    masterkey = q["MASTERKEY"],
                    firstname = q["FIRSTNAME"],
                    lastname = q["LASTNAME"],
                    gender = q["GENDER"],
                    dateofbirth = Convert.ToDateTime(q["DATEOFBIRTH"]),
                    profession = q["PROFESSION"],
                    email = q["EMAIL"],
                    password = q["PASSWORD"],
                    address1 = q["ADDRESS1"],
                    phone = q["PHONE"],
                    celphone = q["CELLPHONE"],
                    town = q["TOWN"],
                    zipcode = q["ZIPCODE"],
                    country = q["COUNTRY"],
                    usedmasterkey = loggedwithcode
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
        public void Respond(string message)
        {
            Response.Clear();
            Response.Write(message);
            Response.End();
        }
    }
}