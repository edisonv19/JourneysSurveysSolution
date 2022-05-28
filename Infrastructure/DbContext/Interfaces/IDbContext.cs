using Infrastructure.DbContext.Utils;

namespace Infrastructure.DbContext.Interfaces
{
    public interface IDbContext
    {
        public IEnumerable<T> GetData<T>(string spName, IEnumerable<Parameter> parameters) where T : new();

        public int ExecTransaction(string spName, IEnumerable<Parameter> parameters);
    }
}