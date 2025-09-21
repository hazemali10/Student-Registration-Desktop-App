using System;
using System.Collections.Generic;

public abstract class Student
{
    public static int NumberOfStudents { get; set; } = 0;
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Gender { get; set; }
    public double AverageGrade { get; set; }
    public List <Course> Courses { get; set; }


    public Student()
    {
        ID = ++NumberOfStudents;
    }

    public abstract void PrintGrades();

    public double CalcAvgGrade()
    {
        double sum = 0;
        for (int i = 0; i < Courses.Count; i++)
        {
            sum += Courses[i].Grade;
        }
        return sum / Courses.Count;
    }

}
