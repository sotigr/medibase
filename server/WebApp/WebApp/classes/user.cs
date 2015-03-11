using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.classes
{
    public class user
    {
        public user() { }
        public user(string _username,
            string _password,
            string _userid,
            string _firstname,
            string _lastname,
            DateTime _dateofbirth,
            string _email,
            string _address1,
            string _address2,
            string _phone,
            string _cellphone)
        {
            this.UserName = _username;
            this.Password = _password;
            this.UserId = _userid;
            this.FirstName = _firstname;
            this.LastName = _lastname;
            this.DateOfBirth = _dateofbirth;
            this.Email = _email;
            this.Address1 = _address1;
            this.Address2 = _address2;
            this.Phone = _phone;
            this.Cellphone = _cellphone;
        }
        public string UserName { set; get; }
        public string Password { set; get; }
        public string UserId { set; get; }
        public string Email { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string Address1 { set; get; }
        public string Address2 { set; get; }
        public string Phone { set; get; }
        public string Cellphone { set; get; }
    }
}