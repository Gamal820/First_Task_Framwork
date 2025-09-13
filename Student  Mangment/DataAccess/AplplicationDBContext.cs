using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Student__Mangment.Models;

namespace Student__Mangment.DataAccess
{
    internal class ApplicatonDBcontext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<HomeworkSubmission> HomeworkSubmissions { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" Data Source=DESKTOP-90TMC45\\MSSQLSERVER2;Database=Student Mangment;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // StudentId is Primary key
            modelBuilder.Entity<Student>().HasKey(e => e.StudentId);
            //Name(up to 100 characters, unicode)
            modelBuilder.Entity<Student>().Property(e => e.Name)
                .IsRequired().HasMaxLength(100).IsUnicode(true);
            //PhoneNumber(exactly 10 characters, not unicode, not required)
            modelBuilder.Entity<Student>().Property(e => e.PhoneNumber)
                .HasMaxLength(10).IsRequired(false);
            //RegisteredOn(DateTime)
            modelBuilder.Entity<Student>().Property(e => e.RegisteredOn).IsRequired();
            //Birthday (not required)
            modelBuilder.Entity<Student>().Property(e => e.Birthday).IsRequired(false);

            // CourseId is Primary k
            modelBuilder.Entity<Course>().HasKey(e => e.CourseId);
            //Name(up to 80 characters, unicode)
            modelBuilder.Entity<Course>().Property(e => e.Name)
                .IsRequired().HasMaxLength(80).IsUnicode(true);
            //Description(unicode, not required)
            modelBuilder.Entity<Course>().Property(e => e.Description).IsRequired(false).IsUnicode(true);

            // ResourceId is Primary key
            modelBuilder.Entity<Resource>().HasKey(e => e.ResourceId);

            //Name(up to 50 characters, unicode)

            modelBuilder.Entity<Resource>().Property(e => e.Name).HasMaxLength(50).IsUnicode(true);
            //Url(not unicode)
            modelBuilder.Entity<Resource>().Property(e => e.Url).IsUnicode(false);

            //Content(string, linking to a file, not unicode)
            modelBuilder.Entity<HomeworkSubmission>().Property(e => e.Content).IsUnicode(false);

            modelBuilder.Entity<StudentCourse>()
               .HasKey(e => new { e.StudentId, e.CourseId });


            modelBuilder.Entity<HomeworkSubmission>()
    .HasKey(e => e.HomeworkId);


        }

    }
}

