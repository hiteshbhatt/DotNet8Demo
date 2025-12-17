namespace DotNetMvcDemo.Web.Models
{
    public class UserRole
    {
        public Guid UserId { get; private set; }
        public int RoleId { get; private set; }

        public User User { get; private set; }
        public Role Role { get; private set; }

        protected UserRole() { }

        public UserRole(Guid userId, int roleId)
        {
            UserId = userId;
            RoleId = roleId;
        }
    }

}
