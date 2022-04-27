using System.Collections.Generic;

namespace Domain.RepoInterfaces
{
    public interface ILocationsRepository
    {
        int Add(Location location);
        Location Get(double latitude, double longitude);
        IEnumerable<Location> GetLocations(int censusRadiusId);
        int Update(int id, int censusRadiusId);
    }
}
