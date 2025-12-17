namespace DotNetMvcDemo.Web.Models
{
    public abstract class VendorOffering
    {
        public Guid OfferingId { get; protected set; }
        public Guid VendorId { get; protected set; }

        public string Name { get; protected set; }
        public Address Address { get; protected set; }

        public bool IsActive { get; protected set; }

        protected VendorOffering() { }

        protected VendorOffering(Guid vendorId, string name, Address address)
        {
            OfferingId = Guid.NewGuid();
            VendorId = vendorId;
            Name = name;
            Address = address;
            IsActive = true;
        }
    }


}
