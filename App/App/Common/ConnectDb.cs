using Microsoft.Data.SqlClient;

namespace App.Common
{
    public class ConnectDb
    {
        public static SqlConnection GetConnection(string DbName)
        {
            string connStr = "Data Source=SERVER\\INNKEYPMS;Initial Catalog=" + DbName + ";Persist Security Info=True;TrustServerCertificate=True;User ID=sa;Pwd=rucha716***";
            try
            {
                return new SqlConnection(connStr);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
    }
}
