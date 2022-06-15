using Domain;

namespace Services.Interfaces
{
    public interface ICodesService
    {
        Code Get(string key, string group);
    }
}
