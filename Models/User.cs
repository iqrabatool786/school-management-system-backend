using System.ComponentModel.DataAnnotations;

namespace MyJwtAuthApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; } // Updated from Username to Name

        [Required]
        [EmailAddress]
        public required string Email { get; set; } // Added Email field

        [Required]
        public required string PasswordHash { get; set; }
    }
}
