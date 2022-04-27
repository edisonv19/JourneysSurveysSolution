namespace Domain.RepoInterfaces
{
    public interface ICodesRepository
    {
        Code Get(string key, string group);
    }
}
