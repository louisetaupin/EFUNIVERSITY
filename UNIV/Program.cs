// See https://aka.ms/new-console-template for more information
UniversityContext context = new UniversityContext();
SeedData data = new SeedData();
//data.CreateData(context);

// foreach (Course t in context.Course.OrderBy(e => e.Title))
// {
//     Console.WriteLine($"Course Name= {t.Title}");
// }
foreach (Student s in context.Student.OrderByDescending(e => e.Id))
{
    Console.WriteLine($"Student Id= {s.Id}");
}