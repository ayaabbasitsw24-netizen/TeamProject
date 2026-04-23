//using Microsoft.EntityFrameworkCore;
//using StudyLovers.Models;
//using System.Collections.Generic;
//using System.Reflection.Emit;

//namespace StudyLovers.Data
//{
//    public class ApplicationDbContext : DbContext
//    {
//        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//            : base(options)
//        {
//        }

//        // 🔹 تعريف الجداول (DbSet)
//        public DbSet<User> Users { get; set; }
//        public DbSet<Student> Students { get; set; }
//        public DbSet<Doctor> Doctors { get; set; }
//        public DbSet<Lecture> Lectures { get; set; }
//        public DbSet<Assignment> Assignments { get; set; }
//        public DbSet<Announcement> Announcements { get; set; }

//        // 🔹 إعداد العلاقات (اختياري لكن مفضل)
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);

//            // مثال: علاقة واحد-لكثير بين Доктор ومحاضرات
//            modelBuilder.Entity<Doctor>()
//                .HasMany(d => d.Lectures)
//                .WithOne(l => l.Doctor)
//                .HasForeignKey(l => l.DoctorId)
//                .OnDelete(DeleteBehavior.Cascade);

//            // مثال: تحديد طول الحقول
//            modelBuilder.Entity<User>()
//                .Property(u => u.Username)
//                .HasMaxLength(100);
//        }
//    }
//}