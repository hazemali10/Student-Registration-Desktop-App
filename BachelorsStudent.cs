using System;

public class BachelorsStudent : Student
{
    public BachelorsStudent()
    {
        Courses = new List<Course>
        {
            new Course { Name = "Math" },
            new Course { Name = "Physics" },
            new Course { Name = "Chemistry" },
            new Course { Name = "Biology" }
        };
    }

    public override void PrintGrades()
    {
        Console.WriteLine("(bachelor)");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(Courses[i]);
        }
        Console.WriteLine("-------------");
    }
}
