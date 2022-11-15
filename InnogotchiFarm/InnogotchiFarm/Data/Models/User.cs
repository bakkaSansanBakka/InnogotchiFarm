using Microsoft.AspNetCore.Identity;

namespace InnogotchiFarm.Data.Models
{
    public class User : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public byte[]? Avatar { get; set; }
    }
}
