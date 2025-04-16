using System.ComponentModel.DataAnnotations;

namespace MyJwtAuthApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Class { get; set; }

        [Required]
        public int RollNo { get; set; }  

        [Required]
        [EmailAddress]
        public required string Email { get; set; }  
    }
}
