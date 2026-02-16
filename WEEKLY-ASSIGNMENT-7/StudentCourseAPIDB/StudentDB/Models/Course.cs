namespace StudentCourseAPIDB.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public List<Student> Students { get; set; }
    }
}
