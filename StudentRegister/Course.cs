using System;

public class Course
{
    public string Name { get; set; } = string.Empty;

    private int grade;
    public int Grade
    {
        get => grade;
        set
        {
            if (value < 0)
                grade = 0;
            else if (value > 100)
                grade = 100;
            else
                grade = value;
        }
    }

    public override string ToString() => $"{Name}: {Grade}";
}
