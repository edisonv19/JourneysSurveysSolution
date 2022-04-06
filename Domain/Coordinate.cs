namespace Domain
{
    public class Coordinate
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        public Coordinate(double lat, double lon)
        {
            Latitude = lat;
            Longitude = lon;
        }
    }
}
