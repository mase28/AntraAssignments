using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Entities;

namespace University
{
    public class Course
    {
        List<Student> students = new List<Student>();

        public string Title;

        public Course(string title)
        {
            this.Title = title;
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public void PrintStudents()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"Student: {students[i].name}, Grade: {students[i].courses[Title]}");
            }
        }
    }
}
