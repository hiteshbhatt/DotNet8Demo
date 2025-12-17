namespace DotNetMvcDemo.Web.Models
{
    public class VendorContact
    {
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string WhatsApp { get; private set; }

        public string ContactPersonName { get; private set; }
        public string AlternatePhone { get; private set; }

        protected VendorContact() { } // EF Core

        public VendorContact(
            string email,
            string phone,
            string whatsApp,
            string contactPersonName,
            string alternatePhone = null)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email is required");

            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Phone number is required");

            Email = email;
            Phone = phone;
            WhatsApp = string.IsNullOrWhiteSpace(whatsApp) ? phone : whatsApp;
            ContactPersonName = contactPersonName;
            AlternatePhone = alternatePhone;
        }

        public void UpdateContact(
            string email,
            string phone,
            string whatsApp,
            string contactPersonName,
            string alternatePhone)
        {
            Email = email;
            Phone = phone;
            WhatsApp = whatsApp;
            ContactPersonName = contactPersonName;
            AlternatePhone = alternatePhone;
        }
    }

}
