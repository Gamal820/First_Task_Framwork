namespace Student__Mangment.Models
{
    public enum ContentType
    {
        Application = 1,
        Pdf = 2,
        Zip = 3
    }
    public class HomeworkSubmission
    {
        public int HomeworkId { get; set; }

        public string Content { get; set; }

        public ContentType ContentType { get; set; }

        public DateTime SubmissionTime { get; set; }


        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}