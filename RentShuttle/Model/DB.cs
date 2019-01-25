using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentShuttle
{
    static class DB
    {
        public static SqlConnection GetSqlkonekcija()
        {
            return new SqlConnection(@"Data Source=DESKTOP-JGEE5L9;Initial Catalog=Rent&Shuttle;Integrated Security=True");
        }
    }
}
