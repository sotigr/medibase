using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.operators
{
    public partial class edit_acc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // All the information are passed in variables.
            // After that, an if statement is initiated that checks if all the fields have a value.
            // If it passes, then the database is updated with the new information
            // and the display account page receives all the new information to display.
            //
            // Karmiris D.

            string Title = Request["s_title"];
            string Name = Request["s_name"];
            string Surname = Request["s_surname"];
            string Gender = Request["s_gender"];
            string Day = Request["s_day"];
            string Month = Request["s_month"];
            string Year = Request["s_year"];
            string Email = Request["s_email"];
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
                && Occupation != null && Occupation != ""
                && Address != null && Address != ""
                && Zip != null && Zip != ""
                && Phone != null && Phone != ""
                && Mobile != null && Mobile != ""
                && City != null && City != ""
                && Country != null && Country != ""
                )
            {
                string query = "UPDATE USERS SET TITLE ='" + Title + "',"
                    + "FIRSTNAME ='" + Name + "',"
                    + "LASTNAME ='" + Surname + "',"
                    + "GENUS ='" + Gender + "',"
                    + "AGE ='" + (DateTime.Now.Year - Convert.ToInt32(Year)) + "',"
                    + "PROFESSION ='" + Occupation + "',"
                    + "EMAIL ='" + Email + "',"
                    + "ADDRESS1 ='" + Address + "',"
                    + "PHONE ='" + Phone + "',"
                    + "CELLPHONE ='" + Mobile + "',"
                    + "TOWN ='" + City + "',"
                    + "ZIPCODE ='" + Zip + "',"
                    + "COUNTRY ='" + Country + "'"
                    + "WHERE EMAIL ='" + ((classes.user)Session["user"]).email + "';";
                Console.WriteLine(query);
                globals.DBINFO.SEND_QUERY(query);

                classes.user SessionUser = (classes.user)Session["user"];
                SessionUser.title = Title;
                SessionUser.firstname = Name;
                SessionUser.lastname = Surname;
                SessionUser.gender = Gender;
                SessionUser.dateofbirth = new DateTime(int.Parse(Year), int.Parse(Month), int.Parse(Day));
                SessionUser.profession = Occupation;
                SessionUser.email = Email;
                SessionUser.address1 = Address;
                SessionUser.phone = Phone;
                SessionUser.celphone = Mobile;
                SessionUser.town = City;
                SessionUser.zipcode = Zip;
                SessionUser.country = Country;
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