using System.ComponentModel.DataAnnotations;

namespace StudyLovers.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [StringLength(100)]
        public string Department { get; set; }

        [StringLength(100)]

        public string Bio { get; set; }

        // 🔗 علاقات
        public ICollection<Lecture>? Lectures { get; set; }
    }
}