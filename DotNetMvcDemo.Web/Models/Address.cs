namespace DotNetMvcDemo.Web.Models
{
    /*
     * Used by Vendor, Venue, Service
       Enables map & radius search
     * */
    public class Address
    {
        public string Country { get; private set; }
        public string State { get; private set; }
        public string City { get; private set; }
        public string Locality { get; private set; }

        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        protected Address() { } // EF

        public Address(
            string country,
            string state,
            string city,
            string locality,
            double latitude,
            double longitude)
        {
            Country = country;
            State = state;
            City = city;
            Locality = locality;
            Latitude = latitude;
            Longitude = longitude;
        }
    }

}
