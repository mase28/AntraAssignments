using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Entities
{
    public class Persons
    {
        public string name { get; set; }
        public DateTime birthday { get; set; }
        List<string> addresses { get; set; }

        public int GetAge()
        {
            int now = DateTime.Now.Year;
            return now - birthday.Year;
        }

        public virtual double GetSalary(double hourly)
        {
            return 2080.0 * hourly;
        }

        public void AddAdress(string addr)
        {
            addresses.Add(addr);
        }

        public void PrintAddresses()
        {
            for (int i = 0; i < addresses.Count; i++)
            {
                Console.WriteLine(addresses[i]);
            }
        }
    }

    public class Student : Persons
    {
        public Dictionary<string, double> courses = new Dictionary<string, double>();

        public Student(string Name, DateTime Birthday)
        {
            this.name = Name;
            this.birthday = Birthday;
        }

        public void AddCourse(string course, char grade)
        {
            if (!courses.ContainsKey(course))
            {
                switch (grade) {

                    case 'A':
                        courses[course] = 4.0;
                        break;

                    case 'B':
                        courses[course] = 3.0;
                        break;

                    case 'C':
                        courses[course] = 2.0;
                        break;

                    case 'D':
                        courses[course] = 1.0;
                        break;

                    case 'F':
                        courses[course] = 0.0;
                        break;
                }
            }
        }

        public double GetGPA()
        {
            double result = 0.0;
            double count = 0.0;

            foreach (string key in courses.Keys)
            {
                result += courses[key];
                count++;
            }
            return result / count;
        }
    }

    public class Instructor : Persons
    {
        Department department;

        DateTime JoinDate;

        public Instructor(string Name, DateTime Birthday, Department d, DateTime joinDate)
        {
            this.name = Name;
            this.birthday = Birthday;
            this.department = d;
            JoinDate = joinDate;
        }

        public override double GetSalary(double hourly)
        {
            return base.GetSalary(hourly) + 10000.0 * (0.1 * (DateTime.Now.Year - JoinDate.Year));
        }
    }
}
