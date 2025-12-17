namespace DotNetMvcDemo.Web.Models
{
    public class Service : VendorOffering
    {
        public ServiceType ServiceType { get; private set; }
        public Pricing Pricing { get; private set; }

        protected Service() { }

        private Service(
            Guid vendorId,
            string name,
            Address address,
            ServiceType serviceType,
            Pricing pricing)
            : base(vendorId, name, address)
        {
            ServiceType = serviceType;
            Pricing = pricing;
        }

        public static Service Create(
            Guid vendorId,
            string name,
            Address address,
            ServiceType serviceType,
            Pricing pricing)
        {
            return new Service(
                vendorId,
                name,
                address,
                serviceType,
                pricing
            );
        }
    }


}
