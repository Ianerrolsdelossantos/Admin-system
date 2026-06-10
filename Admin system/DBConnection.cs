using System.Configuration;
using System.Data.SqlClient;

internal class DBConnection
{
    public static SqlConnection GetConnection()
    {
        string conn = ConfigurationManager.ConnectionStrings["TenantDB"].ConnectionString;
        return new SqlConnection(conn);
    }
}