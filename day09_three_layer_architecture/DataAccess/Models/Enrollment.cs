namespace DataAccess.Models;

internal class Enrollment
{
    public int StudentID { get; set; }
    public Student Student { get; set; }
    
    public int CourseID { get; set; }
    public Course Course { get; set; }
}