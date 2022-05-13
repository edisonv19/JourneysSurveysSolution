using Infrastructure.DbContext.Interfaces;
using System.Data.SqlClient;

namespace Infrastructure.DbContext
{
    public class DbContext : IDbContext
    {
        private string connectionString;

        public DbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public T GetOne<T>(string spName, IEnumerable<object> parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetMany<T>(string spName, IEnumerable<object> parameters)
        {
            throw new NotImplementedException();
        }

        public int Exec(string spName, IEnumerable<object> parameters)
        {
            throw new NotImplementedException();
        }
    }
}
