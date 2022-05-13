namespace Infrastructure.DbContext.Interfaces
{
    public interface IDbContext
    {
        public T GetOne<T>(string spName, IEnumerable<object> parameters);

        public IEnumerable<T> GetMany<T>(string spName, IEnumerable<object> parameters);

        public int Exec(string spName, IEnumerable<object> parameters);
    }
}
