using System;


public class MastersStudent : Student
{
    public MastersStudent()
    {
        Courses = new List<Course>
        {
            new Course { Name = "Advanced Math" },
            new Course { Name = "Physics 3" },
            new Course { Name = "Organic Chemistry" },
            new Course { Name = "Human Biology" }
        };
    }
    public override void PrintGrades()
    {
        Console.WriteLine("(masters)");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(Courses[i]);
        }
        Console.WriteLine("-------------");
    }
}