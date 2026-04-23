using System.ComponentModel.DataAnnotations;

namespace StudyLovers.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; } // 🔗 علاقة مع User

        [StringLength(50)]
      
        public int GoldPoints { get; set; } = 0; // النقاط الذهبية 🏆

        // 🔗 علاقات مع جداول أخرى
        public ICollection<Lecture>? AttendedLectures { get; set; }
    }
}