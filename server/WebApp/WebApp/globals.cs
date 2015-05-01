using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Microsoft.Win32;
namespace WebApp
{
    public class globals
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool FreeConsole();

        [DllImport("kernel32", SetLastError = true)]
        public static extern bool AttachConsole(int dwProcessId);

        public static class DBINFO
        {
            public static string HOST = "192.168.2.7";
            public static string PORT = "3306";
            public static string NAME = "medipli";
            public static string USERNAME = "admin";
            public static string PASSWORD = "sotig19951995!";
            public static MySqlConnection DATABASE_INSTANCE;
            public static bool INSTANTIATE_DATABASE()
            {
                try
                {
                    DATABASE_INSTANCE = new MySqlConnection("Server=" + HOST + ";" + "Database=" + NAME + ";" + "Uid=" + USERNAME + ";" + "Pwd=" + PASSWORD + ";");
                    DATABASE_INSTANCE.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            public static string SEND_QUERY(string SQL_QUERY)
            {
                MySqlCommand COMMAND = DATABASE_INSTANCE.CreateCommand();
                COMMAND.CommandText = SQL_QUERY;
                MySqlDataReader reader = COMMAND.ExecuteReader();
                string res = "";
                while (reader.Read())
                {
                    res = reader.GetString(0);
                }
                reader.Close();
                COMMAND.Dispose();
                return res;
            }
            public static string[] SEND_QUERY_MULT(string SQL_QUERY)
            {
                MySqlCommand COMMAND = DATABASE_INSTANCE.CreateCommand();
                COMMAND.CommandText = SQL_QUERY;
                MySqlDataReader reader = COMMAND.ExecuteReader();
                string[] res = new string[reader.VisibleFieldCount];
                while (reader.Read())
                {
                    for (int x = 0; x < reader.VisibleFieldCount; x++)
                    {
                        try
                        {
                            if (typeof(string).Equals(reader.GetFieldType(x)))
                            {
                                res[x] = reader.GetString(x);
                            }
                            else
                            {
                                res[x] = Convert.ToString(reader.GetString(x));
                            }
                        }
                        catch { }
                    }
                }
                reader.Close();
                COMMAND.Dispose();
                return res;
            }

            public static IDictionary<string, string> SEND_QUERY_MULT_DICT(string SQL_QUERY)
            {
                MySqlCommand COMMAND = DATABASE_INSTANCE.CreateCommand();
                COMMAND.CommandText = SQL_QUERY;
                MySqlDataReader reader = COMMAND.ExecuteReader();
                IDictionary<string, string> dict = new Dictionary<string, string>();
                while (reader.Read())
                {
                    for (int x = 0; x < reader.VisibleFieldCount; x++)
                    {
                        try
                        {
                            if (typeof(string).Equals(reader.GetFieldType(x)))
                            {
                                dict[reader.GetName(x)] = reader.GetString(x);
                            }
                            else
                            {
                                dict[reader.GetName(x)] = Convert.ToString(reader.GetString(x));
                            }
                        }
                        catch { }
                    }
                }
                reader.Close();
                COMMAND.Dispose();
                return dict;
            }
            public static IDictionary<int, IDictionary<string, string>> SEND_QUERY_MULT_DICT_MULT(string SQL_QUERY)
            {
                MySqlCommand COMMAND = DATABASE_INSTANCE.CreateCommand();
                COMMAND.CommandText = SQL_QUERY;
                MySqlDataReader reader = COMMAND.ExecuteReader();
                IDictionary<int, IDictionary<string, string>> dict = new Dictionary<int, IDictionary<string, string>>();
                int cn = 0;
                while (reader.Read())
                {
                    IDictionary<string, string> mlist = new Dictionary<string, string>();
                    for (int x = 0; x < reader.VisibleFieldCount; x++)
                    {

                        try
                        {
                            if (typeof(string).Equals(reader.GetFieldType(x)))
                            {
                                mlist[reader.GetName(x)] = reader.GetString(x);
                            }
                            else
                            {
                                mlist[reader.GetName(x)] = Convert.ToString(reader.GetString(x));
                            }
                        }
                        catch { }
                    }
                    dict[cn] = mlist;
                    cn += 1;
                }
                reader.Close();
                COMMAND.Dispose();
                return dict;
            }

            public static void CLOSE_CONNECTION()
            {
                DATABASE_INSTANCE.Clone();
            }
        }
    }
}