using Microsoft.AspNetCore.Identity;

namespace ScriptSquadWebbshop.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
    }
}
