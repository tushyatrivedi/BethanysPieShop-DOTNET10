using System.ComponentModel.DataAnnotations;

namespace BethanysPieShop_DOTNET10.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public string? Subject { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
