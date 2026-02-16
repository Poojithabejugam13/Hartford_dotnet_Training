using StudentCourseAPIDB.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace StudentCourseAPIDB.Contexts
{
    public class StudentCourseContextDB : DbContext
    {
        public StudentCourseContextDB(DbContextOptions<StudentCourseContextDB> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}