using System;

public partial class Form2 : Form
{
    private int _studentCount; // store the number passed from Form1
    Student[] studentList;

    public Form2(int studentCount)
    {
        InitializeComponent(); // sets up the form controls
        _studentCount = studentCount; // save the value

      studentList= new Student [studentCount];
    }
}
