using System.ComponentModel.DataAnnotations;

namespace MyJwtAuthApp.Models
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }
    }
}
