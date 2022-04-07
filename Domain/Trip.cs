using System;

namespace Domain
{
    public class Trip
    {
        public int Id { get; set; }
        public int? TravelerId { get; set; }
        public DateTime? Date { get; set; }
        public int? SourceId { get; set; }
        public int? SourcePlaceTypeId { get; set; }
        public int? DestinationId { get; set; }
        public int? DestinationPlaceTypeId { get; set; }
        public int? ReasonTripId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int? TransportId { get; set; }
        public string Observations { get; set; }
        public string DateStr { get; set; }
    }
}
