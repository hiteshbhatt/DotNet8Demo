namespace DotNetMvcDemo.Web.Models
{
    public class PerPlatePricing : Pricing
    {
        public int MinGuests { get; private set; }
        public int MaxGuests { get; private set; }

        public PerPlatePricing(decimal price, int minGuests, int maxGuests)
        {
            Price = price;
            MinGuests = minGuests;
            MaxGuests = maxGuests;
        }
    }

}
