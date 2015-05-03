using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
namespace WebApp.operators
{
    public partial class create_acc : System.Web.UI.Page
    {
        // Converts a string to Bytes.
        //
        // Papaioannou S.

        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        // Converts bytes to String.
        //
        // Papaioannou S.
        static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        // The user's information are passed in on variables. As long as they are not "null" or empty
        // a unique Master Key is being created for  that user, and then all the information are being
        // inserted in the Database.
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
                && Pass != null && Pass != ""
                && RePass != null && RePass != ""
                && Pass == RePass
                && Occupation != null && Occupation != ""
                && Address != null && Address != ""
                && Zip != null && Zip != ""
                && Phone != null && Phone != ""
                && Mobile != null && Mobile != ""
                && City != null && City != ""
                && Country != null && Country != ""
                )
            {
                Crc32 crc32 = new Crc32();
                String masterkey = String.Empty;
                foreach (byte b in crc32.ComputeHash(GetBytes(Name + Surname + Email))) masterkey += b.ToString("x2").ToLower();
                if (Month == "January")
                {
                    Month = "1";
                }
                else if (Month == "February")
                {
                    Month = "2";
                }
                else if (Month == "March")
                {
                    Month = "3";
                }
                else if (Month == "April")
                {
                    Month = "4";
                }
                else if (Month == "May")
                {
                    Month = "5";
                }
                else if (Month == "June")
                {
                    Month = "6";
                }
                else if (Month == "July")
                {
                    Month = "7";
                }
                else if (Month == "August")
                {
                    Month = "8";
                }
                else if (Month == "September")
                {
                    Month = "9";
                }
                else if (Month == "October")
                {
                    Month = "10";
                }
                else if (Month == "November")
                {
                    Month = "11";
                }
                else if (Month == "December")
                {
                    Month = "12";
                }
                string query = "INSERT INTO USERS VALUES (NULL ,'"
                                       + masterkey + "','"
                                       + Title + "','"
                                       + Name + "','"
                                       + Surname + "','"
                                       + Gender + "','"
                                       + new DateTime(int.Parse(Year), int.Parse(Month), int.Parse(Day)).ToString("yyyy-MM-dd") + "','"
                                       + Occupation + "','"
                                       + Email + "','"
                                       + Pass + "','"
                                       + Address + "','"
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

    // A Hash Algorithm for hte creation of hashes requuired for the generation of a user's unique Master Key.
    //
    // Papaioannou S.
    class Crc32 : HashAlgorithm
    {
        public const UInt32 DefaultPolynomial = 0xedb88320u;
        public const UInt32 DefaultSeed = 0xffffffffu;

        private static UInt32[] defaultTable;

        private readonly UInt32 seed;
        private readonly UInt32[] table;
        private UInt32 hash;

        public Crc32()
            : this(DefaultPolynomial, DefaultSeed)
        {
        }

        public Crc32(UInt32 polynomial, UInt32 seed)
        {
            table = InitializeTable(polynomial);
            this.seed = hash = seed;
        }

        public override void Initialize()
        {
            hash = seed;
        }

        protected override void HashCore(byte[] buffer, int start, int length)
        {
            hash = CalculateHash(table, hash, buffer, start, length);
        }

        protected override byte[] HashFinal()
        {
            var hashBuffer = UInt32ToBigEndianBytes(~hash);
            HashValue = hashBuffer;
            return hashBuffer;
        }

        public override int HashSize { get { return 32; } }

        public static UInt32 Compute(byte[] buffer)
        {
            return Compute(DefaultSeed, buffer);
        }

        public static UInt32 Compute(UInt32 seed, byte[] buffer)
        {
            return Compute(DefaultPolynomial, seed, buffer);
        }

        public static UInt32 Compute(UInt32 polynomial, UInt32 seed, byte[] buffer)
        {
            return ~CalculateHash(InitializeTable(polynomial), seed, buffer, 0, buffer.Length);
        }

        private static UInt32[] InitializeTable(UInt32 polynomial)
        {
            if (polynomial == DefaultPolynomial && defaultTable != null)
                return defaultTable;

            var createTable = new UInt32[256];
            for (var i = 0; i < 256; i++)
            {
                var entry = (UInt32)i;
                for (var j = 0; j < 8; j++)
                    if ((entry & 1) == 1)
                        entry = (entry >> 1) ^ polynomial;
                    else
                        entry = entry >> 1;
                createTable[i] = entry;
            }

            if (polynomial == DefaultPolynomial)
                defaultTable = createTable;

            return createTable;
        }

        private static UInt32 CalculateHash(UInt32[] table, UInt32 seed, IList<byte> buffer, int start, int size)
        {
            var crc = seed;
            for (var i = start; i < size - start; i++)
                crc = (crc >> 8) ^ table[buffer[i] ^ crc & 0xff];
            return crc;
        }

        private static byte[] UInt32ToBigEndianBytes(UInt32 uint32)
        {
            var result = BitConverter.GetBytes(uint32);

            if (BitConverter.IsLittleEndian)
                Array.Reverse(result);

            return result;
        }
    }
}