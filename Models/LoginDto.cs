using System.ComponentModel.DataAnnotations;

namespace MyJwtAuthApp.Models
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required string PasswordHash { get; set; }
    }
}
