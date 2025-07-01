using System.ComponentModel.DataAnnotations;

namespace Task4.Models
{
    public class UserModel
    {
        [Required]
        public string  Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

    }
}
