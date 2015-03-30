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
            string Surname = Request["s_surname"];
            string Gender = Request["s_gender"];
            string Day = Request["s_day"];
            string Month = Request["s_month"];
            string Year = Request["s_year"];
            string Email = Request["s_email"];
            string Pass = Request["s_pass"];
            string RePass = Request["s_repass"];
            string Occupation = Request["s_occ"];
            string Address = Request["s_addr"];
            string Zip = Request["s_zip"];
            string Phone = Request["s_phone"];
            string Mobile = Request["s_mobile"];
            string City = Request["s_city"];
            string Country = Request["s_country"];
            if (Title != null && Title != ""
                && Name != null && Name != ""
                && Surname != null && Surname != ""
                && Gender != null && Gender != ""
                && Day != null && Day != ""
                && Month != null && Month != ""
                && Year != null && Year != ""
                && Email != null && Email != ""
                && Pass  != null && Pass != ""
                && RePass != null && RePass != ""
                && Pass == RePass
                && Occupation != null && Occupation != "" 
                && Address != null && Address != ""
                && Zip != null && Zip != ""
                && Phone != null && Phone != ""
                && Mobile  != null && Mobile  != "" 
                && City != null && City != ""
                && City != null && City != ""
                )
            {
                string query = "INSERT INTO USERS VALUES ('' ,'"
                                       + Title + "','"
                                       + Name + "','"
                                       + Surname + "','"
                                       + Gender + "','"
                                       + (DateTime.Now.Year - Convert.ToInt32(Year)) + "','"
                                       + Occupation + "','"
                                       + Email + "','"
                                       + Pass + "','"
                                       +  "','"
                                       + Address + "','"
                                       + "','"
                                       + Phone + "','"
                                       + Mobile + "','"
                                       + City + "','"
                                       + Zip + "','"
                                       + Country + "'"
                                       + ");";
                Console.WriteLine(query);
                globals.DBINFO.SEND_QUERY(query);
                Respond("1");
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