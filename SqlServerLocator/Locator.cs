using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.SqlServer.Management.Smo;

namespace SqlServerLocator
{
    public class Locator
    {
        public IEnumerable<string> GetLocal()
        {
            var table = SmoApplication.EnumAvailableSqlServers(true);
            return (from DataRow row in table.Rows
                    select row["Name"].ToString());
        }

        public bool TestConnection(string serverName)
        {
            using (var conn = new SqlConnection("Data Source=" + serverName + ";Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    return conn.State == ConnectionState.Open;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}
