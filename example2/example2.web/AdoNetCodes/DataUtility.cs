using Microsoft.Data.SqlClient;
namespace example2.web.AdoNetCodes
{
    public class DataUtility
    {
        public readonly string _connectionString;

        public DataUtility(string connectionStirng)
        {
            _connectionString = connectionStirng;
        }
        public void ExecuteQuery(string execute)
        {
            using SqlConnection connection = new SqlConnection();
            connection.Open();
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = execute;
            command.ExecuteNonQuery();
        }
    }
}
