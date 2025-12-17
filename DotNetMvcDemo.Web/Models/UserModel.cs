namespace DotNetMvcDemo.Web.Models
{
    public class User
    {
        public Guid UserId { get; private set; }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string Email { get; private set; }
        public string Phone { get; private set; }

        public bool IsEmailVerified { get; private set; }
        public bool IsPhoneVerified { get; private set; }

        public UserStatus Status { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime? LastLoginAt { get; private set; }

        // Navigation
        private readonly List<UserRole> _roles = new();
        public IReadOnlyCollection<UserRole> Roles => _roles;

        private readonly List<VendorUser> _vendorLinks = new();
        public IReadOnlyCollection<VendorUser> VendorLinks => _vendorLinks;

        protected User() { } // EF Core

        private User(
            string firstName,
            string lastName,
            string email,
            string phone)
        {
            UserId = Guid.NewGuid();

            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;

            Status = UserStatus.Active;
            CreatedAt = DateTime.UtcNow;
        }

        // Factory
        public static User Create(
            string firstName,
            string lastName,
            string email,
            string phone)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email is required");

            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Phone is required");

            return new User(firstName, lastName, email, phone);
        }

        // Domain Behaviors
        public void VerifyEmail()
        {
            IsEmailVerified = true;
        }

        public void VerifyPhone()
        {
            IsPhoneVerified = true;
        }

        public void UpdateLastLogin()
        {
            LastLoginAt = DateTime.UtcNow;
        }

        public void Block()
        {
            Status = UserStatus.Blocked;
        }
    }

}
