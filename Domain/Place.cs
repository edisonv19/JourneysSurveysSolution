using Domain.Interfaces;
using System.Collections.Generic;

namespace Domain
{
    public class Place : IResultFactoriable
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Coordinates_Json { get; set; }
        public int? ParentId { get; set; }

        public IList<Coordinate> Coordinates { get; set; } = new List<Coordinate>();

        public bool Contains(Coordinate location)
        {
            bool contains = false;
            for (int i = 0, j = Coordinates.Count - 1; i < Coordinates.Count; j = i++)
            {
                if (((Coordinates[i].Latitude > location.Latitude) != (Coordinates[j].Latitude > location.Latitude)) && (location.Longitude < (Coordinates[j].Longitude - Coordinates[i].Longitude) * (location.Latitude - Coordinates[i].Latitude) / (Coordinates[j].Latitude - Coordinates[i].Latitude) + Coordinates[i].Longitude))
                {
                    contains = !contains;
                }
            }
            return contains;
        }
    }
}
