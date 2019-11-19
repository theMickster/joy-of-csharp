namespace GangOfFour.Core.Entities
{
    public class Hometown
    {
        public string City { get; }

        public string StateProvinceRegion { get; }

        public string Country { get; }

        public Hometown(string city, string stateProvinceRegion, string country)
        {
            City = city;
            StateProvinceRegion = stateProvinceRegion;
            Country = Country;
        }
    }
}