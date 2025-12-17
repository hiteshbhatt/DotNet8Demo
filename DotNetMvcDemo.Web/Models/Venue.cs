namespace DotNetMvcDemo.Web.Models
{
    public class Venue : VendorOffering
    {
        public VenueType VenueType { get; private set; }

        public int CapacityMin { get; private set; }
        public int CapacityMax { get; private set; }

        public Pricing Pricing { get; private set; }

        protected Venue() { }

        private Venue(
            Guid vendorId,
            string name,
            Address address,
            VenueType venueType,
            int capacityMin,
            int capacityMax,
            Pricing pricing)
            : base(vendorId, name, address)
        {
            VenueType = venueType;
            CapacityMin = capacityMin;
            CapacityMax = capacityMax;
            Pricing = pricing;
        }

        public static Venue Create(
            Guid vendorId,
            string name,
            Address address,
            VenueType venueType,
            int capacityMin,
            int capacityMax,
            Pricing pricing)
        {
            return new Venue(
                vendorId,
                name,
                address,
                venueType,
                capacityMin,
                capacityMax,
                pricing
            );
        }
    }


}
