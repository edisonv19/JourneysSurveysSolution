using Infrastructure.DbContext.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace Infrastructure.DbContext
{
    public class DbContext : IDbContext
    {
        private readonly string _connectionString;

        public DbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<T> GetData<T>(string spName, IEnumerable<object> parameters) where T : new()
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            try
            {
                using var command = new SqlCommand();
                command.Connection = connection;

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = spName;

                command.Parameters.AddRange((Array)parameters);

                var reader = command.ExecuteReader();

                var rows = reader.GetSchemaTable().Rows;

                return DbSqlServerUtils.GetDataList<T>(rows);

            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public int ExecTransaction(string spName, IEnumerable<object> parameters)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            using var transaction = connection.BeginTransaction();
            int id;

            try
            {
                using var command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = transaction;

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = spName;

                command.Parameters.AddRange((Array)parameters);

                id = (int)command.ExecuteScalar();

                transaction.Commit();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }

            return id;
        }
    }
}
