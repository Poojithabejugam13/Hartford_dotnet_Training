namespace StudentCourseWEBAPI.Models
{
    public class Course
    {
        public int CourseId { get; set; }    // Primary Key
        public string Title { get; set; }
        public List<Student>? Students { get; set; }
    }
}
