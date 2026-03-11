using System.ComponentModel.DataAnnotations;

namespace AllTrails.Models
{
    public class UserProfile
    {
        [Key]
        public string IdentityId { get; set; } = string.Empty; // PK

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
