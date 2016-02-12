namespace ShapeShifters.UI.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }
        
        public string CountryName { get; set;}

        public string AddressLine1 { get; set;}

        public string AddressLine2 { get; set;}

        public string AddressLine3 { get; set;}

        public string City { get; set; }

        public string GPSCoordinates { get; set; }

        public string WebUrl { get; set; }
    }
}