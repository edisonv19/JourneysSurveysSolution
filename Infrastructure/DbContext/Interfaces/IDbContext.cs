namespace Infrastructure.DbContext.Interfaces
{
    public interface IDbContext
    {
        public IEnumerable<T> GetData<T>(string spName, IEnumerable<object> parameters) where T : new();

        public int ExecTransaction(string spName, IEnumerable<object> parameters);
    }
}