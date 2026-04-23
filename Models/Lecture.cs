using System.ComponentModel.DataAnnotations;

namespace StudyLovers.Models
{
    public class Lecture
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(255)]
        public string FilePath { get; set; } // مسار الملف المرفوع

        [Required]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        [StringLength(100)]
        public string SubjectName { get; set; }

        public DateTime UploadDate { get; set; } = DateTime.Now;

        public int ViewsCount { get; set; } = 0;
    }
}