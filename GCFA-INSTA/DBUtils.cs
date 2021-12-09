using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GCFA_INSTA
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"(LocalDB)\MSSQLLocalDB";
            string database = "C:/Users/dalin/Documents/workspace/Projet_de_groupe/applications-program/GCFA-INSTA/Database1.mdf";
            return DBSQLServerUtils.GetDBConnection(datasource, database);
        }
    }
}
