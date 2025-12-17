namespace DotNetMvcDemo.Web.Models
{
    public class Vendor
    {
        public Guid VendorId { get; set; }
        public string VendorCode { get; set; }
        public string DisplayName { get; set; }

        public VendorType VendorType { get;  set; }
        //public VendorStatus Status { get; private set; }
        //public VerificationStatus VerificationStatus { get; private set; }

        //public VendorContact Contact { get; private set; }
          public Address RegisteredAddress { get; set; }
        //public TrustProfile TrustProfile { get; private set; }

        //private readonly List<VendorUser> _users = new();
        //public IReadOnlyCollection<VendorUser> Users => _users;

        //protected Vendor() { }

        //private Vendor(string displayName, VendorType vendorType, VendorContact contact)
        //{
        //    VendorId = Guid.NewGuid();
        //    VendorCode = $"VV-{Random.Shared.Next(100000, 999999)}";
        //    DisplayName = displayName;
        //    VendorType = vendorType;
        //    Contact = contact;

        //    Status = VendorStatus.Draft;
        //    VerificationStatus = VerificationStatus.Unverified;
        //}

        //public static Vendor Create(
        //    string displayName,
        //    VendorType vendorType,
        //    VendorContact contact)
        //{
        //    return new Vendor(displayName, vendorType, contact);
        //}

        //public void AddUser(Guid userId, VendorUserRole role)
        //{
        //    _users.Add(new VendorUser(VendorId, userId, role));
        //}

        //public void Verify()
        //{
        //    VerificationStatus = VerificationStatus.Verified;
        //    Status = VendorStatus.Active;
        //}
    }


}
