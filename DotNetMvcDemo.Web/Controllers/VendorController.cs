using DotNetMvcDemo.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetMvcDemo.Web.Controllers
{
    public class VendorController : Controller
    {
        static List<Vendor> vendors = new List<Vendor>()
        {
            new Vendor
            {
                VendorId = Guid.NewGuid(),
                VendorCode = "VV-123456",
                DisplayName = "Contoso Supplies",
                VendorType = VendorType.Service,
                RegisteredAddress = new Address("India","KA","Bangalore","Indiranagar",12.9716,77.5946)

            },
            new Vendor
            {
                VendorId = Guid.NewGuid(),
                VendorCode = "VV-654321",
                DisplayName = "Fabrikam Services",
                VendorType = VendorType.Service,
                RegisteredAddress = new Address("India","MH","Mumbai","Andheri",19.0760,72.8777)

            }
        };
        public IActionResult Index()
        {
            return View(vendors);
        }
    }
}
