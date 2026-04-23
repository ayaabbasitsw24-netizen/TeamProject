using System.ComponentModel.DataAnnotations;

namespace StudyLovers.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Username { get; set; }

        [Required, StringLength(255)]
        public string PasswordHash { get; set; } // 🔐 مشفرة

        [Required, StringLength(50)]
        public string UserType { get; set; } // "Student" أو "Doctor"

        [StringLength(200)]
        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}