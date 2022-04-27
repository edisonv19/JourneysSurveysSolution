using System.Collections.Generic;

namespace Domain.RepoInterfaces
{
    public interface IPlacesRepository
    {
        int Add(Place place);

        Place Get(string code);

        IEnumerable<Place> GetPlaces(int? categoryId, string description, int? parentId, string code);
    }
}
