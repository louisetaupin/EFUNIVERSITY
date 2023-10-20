public class Course
{
    public int Id {get; set;}
    public string Title {get; set;}
    public int Credits {get; set;}
    public List<Enrollment> Enrollments {get; set;}
    public Course (int id, string title, string credits, List<Enrollment> enrollments)
    {
        Id=id;
        Title=title;
        Credits=credits;
        Enrollments=enrollments;
    }
}