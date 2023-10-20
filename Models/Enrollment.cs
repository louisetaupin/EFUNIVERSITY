public enum Grade {A, B, C, D, F};
public class Enrollment
{
    public int Id {get; set;}
    public Grade? Grade {get; set;}
    public int StudentId {get; set;}
    public int CourseId {get; set;}
    public Student Student {get; set;}
    public Course Course {get; set;}
    public Enrollment(int id, Grade grade, int studentId, int courseid, Student student, Course course)
    {
        Id=id;
        Grade=grade;
        StudentId=studentId;
        CourseId=courseid;
        Student=student;
        Course=course;
    }
    public Enrollment(int id, int studentId, int courseid, Student student, Course course)
    {
        Id=id;
        StudentId=studentId;
        CourseId=courseid;
        Student=student;
        Course=course;
    }
}