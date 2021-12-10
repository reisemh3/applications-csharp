using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GCFA_INSTA
{
    class DBSQLServerUtils
    {
        public static SqlConnection
                 GetDBConnection(string datasource, string database)
        {
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dalin\Documents\workspace\Projet_de_groupe\applications-program\GCFA-INSTA\Database1.mdf;Connect Timeout=30
            // Data Source=TRAN-VMWARE\SQLEXPRESS;Initial Catalog=simplehr;Persist Security Info=True;User ID=sa;Password=12345
            // Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dalin\Documents\workspace\Projet_de_groupe\applications-program\GCFA-INSTA\Database1.mdf;Integrated Security=True
            //string connString = "np:\\.\pipe\LOCALDB#8AF6E2EA\tsql\query";
            //Data Source=DESKTOP-4BIKOBS\SQLEXPRESS;Initial Catalog=ApplicationsDB;Integrated Security=True;Pooling=False
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Integrated Security=True;Pooling=False";
            //SqlConnection conn = new SqlConnection(@"Server=np:\\.\pipe\LOCALDB#7B78FF27\tsql\query");
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
