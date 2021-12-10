using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GCFA_INSTA
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Connexion());

            Console.WriteLine("Getting Connection ...");
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                Console.WriteLine("Openning Connection ...");
                string queryString ="SELECT * FROM dbo.Applicant;";
                SqlCommand command = new SqlCommand(queryString, conn);
                conn.Open();
                Console.WriteLine("Connection successful!");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("using SqlDataReader");
                if (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}, {1}",
                        reader[0], reader[1]));
                }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.Read();

        }

    }
}
