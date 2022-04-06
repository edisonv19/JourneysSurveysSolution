using Domain.Interfaces;

namespace Domain
{
    public class Location : IResultFactoriable
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? CensusRadiusId { get; set; }
        public int? ZoneId { get; set; }
        public int? CategoryId { get; set; }
        public string Description { get; set; }
        public int Radius { get; set; }
        public int? ResidentialZoneTypeId { get; set; }
    }
}
