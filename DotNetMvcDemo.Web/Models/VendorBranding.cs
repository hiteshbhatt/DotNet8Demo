namespace DotNetMvcDemo.Web.Models
{
    public class VendorBranding
    {
        public string LogoUrl { get; private set; }
        public string CoverImageUrl { get; private set; }
        public string Tagline { get; private set; }

        protected VendorBranding() { }

        public VendorBranding(string logoUrl, string coverImageUrl, string tagline)
        {
            LogoUrl = logoUrl;
            CoverImageUrl = coverImageUrl;
            Tagline = tagline;
        }
    }

}
