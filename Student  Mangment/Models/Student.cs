using Student__Mangment.DataAccess;

namespace Student__Mangment.Models
{
    public class Student
    {

        public int StudentId { get; set; }
        public string Name { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime? Birthday { get; set; }
        public List<StudentCourse> CourseEnrollments { get; set; } = new List<StudentCourse>();

        public List<HomeworkSubmission> HomeworkSubmissions { get; set; } = new List<HomeworkSubmission>();
    }
}