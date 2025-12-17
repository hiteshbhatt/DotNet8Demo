namespace DotNetMvcDemo.Web.Models
{
    public class Role
    {
        public int RoleId { get; private set; }
        public string Name { get; private set; }

        protected Role() { }

        public Role(int roleId, string name)
        {
            RoleId = roleId;
            Name = name;
        }
    }

}
