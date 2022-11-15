using System.ComponentModel.DataAnnotations;

namespace InnogotchiFarm.DataTransferObjects
{
    public class UserForRegistrationDto
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        public ICollection<string> Roles { get; set; }
    }
}
