using Domain.Interfaces;

namespace Domain
{
    public class Traveler : IResultFactoriable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public int? PlaceId { get; set; }
        public int? SocioEconomicLevelId { get; set; }
        public int? MyProSexIdperty { get; set; }
        public int? EducationLevelId { get; set; }
        public int? OccupationId { get; set; }
        public string Identification { get; set; }
    }
}
