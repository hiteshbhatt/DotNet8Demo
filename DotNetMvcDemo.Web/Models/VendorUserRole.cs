using DotNetMvcDemo.Web.Models;

public enum VendorUserRole
{
    Owner = 1,
    Manager = 2,
    Staff = 3
}

public class VendorUser
{
    public Guid VendorUserId { get; private set; }

    public Guid VendorId { get; private set; }
    public Guid UserId { get; private set; }

    public VendorUserRole Role { get; private set; }

    public Vendor Vendor { get; private set; }
    public User User { get; private set; }

    protected VendorUser() { }

    public VendorUser(Guid vendorId, Guid userId, VendorUserRole role)
    {
        VendorUserId = Guid.NewGuid();
        VendorId = vendorId;
        UserId = userId;
        Role = role;
    }
}
