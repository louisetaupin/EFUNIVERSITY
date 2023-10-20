public class Student
{
    public int Id {get; set;}
    public string LastName {get; set;}
    public string FirstName {get; set;}
    public DateTime EnrollmentDate {get; set;}
    public List<Enrollment> Enrollments {get; set;}
    public Student(int id, string last, string first, DateTime date, List<Enrollment> enrollments)
    {
        Id=id;
        LastName=last;
        FirstName=first;
        EnrollmentDate=date;
        Enrollments=enrollments;
    }
}