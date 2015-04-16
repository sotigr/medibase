using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.classes
{
    public class user
    {
        public user() { }
        public string id { set; get; }
        public string masterkey { set; get; }
        public string title { set; get; }
        public string firstname { set; get; }
        public string lastname { set; get; }
        public string gender { set; get; }
        public DateTime dateofbirth { set; get; }
        public string profession { set; get; }
        public string email { set; get; }
        public string password { set; get; }
        public string address1 { set; get; } 
        public string phone { set; get; }
        public string celphone { set; get; }
        public string town { set; get; }
        public string zipcode { set; get; }
        public string country { set; get; } 
        public bool usedmasterkey { set; get; }
    }
}