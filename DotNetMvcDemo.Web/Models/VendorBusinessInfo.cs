namespace DotNetMvcDemo.Web.Models
{
    public class VendorBusinessInfo
    {
        public string LegalName { get; private set; }
        public string GstNumber { get; private set; }
        public string PanNumber { get; private set; }
        public string RegistrationType { get; private set; }

        protected VendorBusinessInfo() { }

        public VendorBusinessInfo(
            string legalName,
            string gstNumber,
            string panNumber,
            string registrationType)
        {
            LegalName = legalName;
            GstNumber = gstNumber;
            PanNumber = panNumber;
            RegistrationType = registrationType;
        }
    }

}
