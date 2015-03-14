using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using WebApp;
using System.Data.SqlClient;
namespace WebApp
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            globals.FreeConsole(); 
            globals.AllocConsole(); 
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".:"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("Console Initialized"); Console.ForegroundColor = ConsoleColor.White; Console.Write(":."); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("(For Bebug Only)\n"); Console.ForegroundColor = ConsoleColor.White;
         /*   if (globals.DBINFO.INSTANTIATE_DATABASE())
            {
                Console.WriteLine("\nMySQL: Connected with " + globals.DBINFO.DATABASE_INSTANCE.Database + " at " + globals.DBINFO.DATABASE_INSTANCE.DataSource); 
            }
            else
            {
                Console.WriteLine("Database Connection FAILED");
            }*/
        }
        void Session_Start(object sender, EventArgs e)
        { 
            
        }
        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Application Error.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
