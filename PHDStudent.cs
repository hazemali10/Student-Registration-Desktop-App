using System;

[Serializable]
public class PHDStudent : Student
{
    public PHDStudent()
    {
        Courses = new List<Course>
        {
            new Course { Name = "Quantim Mechanics" },
            new Course { Name = "Physics of Semiconductors" },
            new Course { Name = "Electrical Circuits 3" },
            new Course { Name = "Differential Equations" }
        };
    }

    public override void PrintGrades()
    {
        Console.WriteLine("(phd)");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(Courses[i]);
        }
        Console.WriteLine("-------------");
    }

}
