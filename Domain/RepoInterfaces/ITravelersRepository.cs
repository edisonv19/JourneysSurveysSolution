namespace Domain.RepoInterfaces
{
    public interface ITravelersRepository
    {
        int Add(Traveler traveler);

        Traveler Get(string identification);
    }
}
