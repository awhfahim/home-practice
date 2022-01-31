using Microsoft.Data.SqlClient;
namespace Revise.web.AdoNetCodes
{
    public class DataUtility
    {
        private readonly string _connectionString;

        public DataUtility(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void InsertData(string Insert, IDictionary<string, object> parameters)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            using SqlCommand command = connection.CreateCommand();
            command.CommandText = Insert;
            if(parameters != null)
            {
                foreach(var item in parameters)
                {
                    command.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }
            }
            command.ExecuteNonQuery();
        }
    }
}
