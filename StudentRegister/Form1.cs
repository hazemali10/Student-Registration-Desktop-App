using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentRegister
{
    public partial class Form1 : Form
    {
        private bool registering=false;
        int totalNumberOfStudents=0;
        int numberOfNewStudents=0;
        private int _currentStudent = 0;
        private int CurrentStudent
        {
            get => _currentStudent;
            set
            {
                _currentStudent = value;
                label2.Text = $"Registering student No.{_currentStudent + 1}";
            }
        }
        List<Student> students = new List<Student>();



        public Form1()
        {
            InitializeComponent();
            label2.Text = $"Registering student No.{_currentStudent + 1}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
          
            // convert string to int
            if (int.TryParse(textBox1.Text, out numberOfNewStudents))
            {
                // If successful, open a new panel and pass the number
                panel3.Visible = false;
                panel2.Visible = false;
                panel4.Visible = true;
                registering = true; 

            }
            else
            {
                // If the conversion fails, show an error message
                MessageBox.Show("Please enter a valid number.");
            }
        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            if (registering)
            {
                panel3.Visible = false;
                panel4.Visible = true;
                panel2.Visible = false;
                panel4.BringToFront();
            }
            else {
                panel3.Visible = true;
                panel4.Visible = false;
                panel2.Visible = false;
                panel3.BringToFront();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = true;
            panel2.BringToFront();


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem?.ToString())
            {
                case "Masters":
                    label10.Text = "Advanced Maths";
                    label9.Text = "Physics 3";
                    label8.Text = "Organic Chemistry";
                    label7.Text = "Human Biology";
                    goto case "ALL";

                case "PHD":
                    label10.Text = "Quantum Mechanics";
                    label9.Text = "Physics of Semiconductors";
                    label8.Text = "Electrical Circuits 3";
                    label7.Text = "Differential Equations";
                    goto case "ALL";

                case "Bachelors":
                    label10.Text = "Maths";
                    label9.Text = "Physics";
                    label8.Text = "Chemistry";
                    label7.Text = "Biology";
                    goto case "ALL";

                case "ALL":
                    // common code for all cases
                    label10.Visible = true;
                    label9.Visible = true;
                    label8.Visible = true;
                    label7.Visible = true;
                    label6.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    break;
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) || int.TryParse(textBox2.Text, out int value5))
            {
                MessageBox.Show("Please enter a valid name.");
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender!");
                return;
            }

            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a level!");
                return;
            }

            if (!int.TryParse(textBox3.Text, out int value) || value<0 || value>100)
            {
                MessageBox.Show("Please enter a number between 0-100 in Grades");
                return;
            }
            if (!int.TryParse(textBox4.Text, out int value1) || value1 < 0 || value1 > 100)
            {
                MessageBox.Show("Please enter a number between 0-100 in Grades");
                return;
            }
            if (!int.TryParse(textBox5.Text, out int value2) || value2 < 0 || value2 > 100)
            {
                MessageBox.Show("Please enter a number between 0-100 in Grades");
                return;

            }
            if (!int.TryParse(textBox6.Text, out int value3) || value3 < 0 || value3 > 100)
            {
                MessageBox.Show("Please enter a number between 0-100 in Grades");
                return;
            }



            switch (comboBox2.SelectedItem?.ToString())
            {
                case "Masters":
                    var newStudent = new MastersStudent();
                    newStudent.Name = textBox2.Text;
                    newStudent.Gender = comboBox1.Text;
                    newStudent.ID = ++totalNumberOfStudents;

                    // Assign grades
                    newStudent.Courses[0].Grade = int.Parse(textBox3.Text);
                    newStudent.Courses[1].Grade = int.Parse(textBox4.Text);
                    newStudent.Courses[2].Grade = int.Parse(textBox5.Text);
                    newStudent.Courses[3].Grade = int.Parse(textBox6.Text);

                    students.Add(newStudent);
                    break;

                case "Bachelors":
                    var newStudent1 = new BachelorsStudent();
                    newStudent1.Name = textBox2.Text;
                    newStudent1.Gender = comboBox1.Text;
                    newStudent1.ID = ++totalNumberOfStudents;
                    // Assign grades
                    newStudent1.Courses[0].Grade = int.Parse(textBox3.Text);
                    newStudent1.Courses[1].Grade = int.Parse(textBox4.Text);
                    newStudent1.Courses[2].Grade = int.Parse(textBox5.Text);
                    newStudent1.Courses[3].Grade = int.Parse(textBox6.Text);

                    students.Add(newStudent1);
                    break;

                case "PHD":
                    var newStudent2 = new MastersStudent();
                    newStudent2.Name = textBox2.Text;
                    newStudent2.Gender = comboBox1.Text;
                    newStudent2.ID = ++totalNumberOfStudents;
                    // Assign grades
                    newStudent2.Courses[0].Grade = int.Parse(textBox3.Text);
                    newStudent2.Courses[1].Grade = int.Parse(textBox4.Text);
                    newStudent2.Courses[2].Grade = int.Parse(textBox5.Text);
                    newStudent2.Courses[3].Grade = int.Parse(textBox6.Text);

                    students.Add(newStudent2);
                    break;




            }
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            label10.Visible = false;
            label9.Visible = false;
            label8.Visible = false;
            label7.Visible = false;
            label6.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            MessageBox.Show($"{students[totalNumberOfStudents-1].Name} has been registered");
            CurrentStudent++;
            if (_currentStudent >= numberOfNewStudents)
            {
                UpdateStudentList();
                textBox1.Text = "";
                panel2.Visible = false;
                panel3.Visible = true;
                panel4.Visible = false;
                panel3.BringToFront();
                registering= false;
               
                MessageBox.Show("All students have been registered!");
                CurrentStudent = 0;
                numberOfNewStudents = 0;
                return;
            }
        }


        // Displaying Students
        private void UpdateStudentList()
        {
            // Clear previous items
            Registered_Students.Items.Clear();

            // Add all students
            foreach (var s in students)
            {
                string courses = string.Join(", ", s.Courses.Select(c => $"{c.Name}: {c.Grade}"));
                Registered_Students.Items.Add($"{s.Name} ({s.Gender})(ID:{s.ID}) - {courses}");
            }
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

