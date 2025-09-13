using Student__Mangment.DataAccess;

namespace Student__Mangment.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public List<StudentCourse> StudentsEnrolled { get; set; } = new List<StudentCourse>();


        public List<Resource> Resources { get; set; } = new List<Resource>();


        public List<HomeworkSubmission> HomeworkSubmissions { get; set; } = new List<HomeworkSubmission>();

    }
}