using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Entities;

namespace University
{
    public class Department
    {
        private Instructor head;

        public Instructor Head { get { return head; } set { head = value; } }
        double budget { get; set; }

        List<Course> courses = new List<Course>();

        string name { get; set; }

        public Department(string Name, double budget)
        {
            this.name = Name;
            this.budget = budget;
        }

        public void AddCourse(Course c)
        {
            courses.Add(c);
        }
    }
}
