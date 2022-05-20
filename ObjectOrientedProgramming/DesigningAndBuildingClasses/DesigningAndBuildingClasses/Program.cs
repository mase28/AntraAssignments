using University.Entities;

namespace University
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Department Math = new Department("Math", 60000.50);
            Department English = new Department("English", 50000.25);

            Course math101 = new Course("Math 101");
            Course math203 = new Course("Math 203");

            Course eng101 = new Course("English 101");
            Course eng254 = new Course("English 254");

            Course[] courses = new Course[] { math101, math203, eng101, eng254 };

            Math.AddCourse(math101);
            Math.AddCourse(math203);

            English.AddCourse(eng101);
            English.AddCourse(eng254);

            Instructor Bob = new Instructor("Mr. Bob", new DateTime(1985, 5, 24), Math, new DateTime(2021, 4, 12));
            Instructor Sally = new Instructor("Mrs. Sally", new DateTime(1990, 8, 12), Math, new DateTime(2005, 2, 28));

            Instructor Dave = new Instructor("Mr. Dave", new DateTime(1982, 2, 8), English, new DateTime(2008, 4, 21));
            Instructor Jill = new Instructor("Mrs. Jill", new DateTime(1989, 12, 24), English, new DateTime(2014, 10, 11));

            Instructor[] instructors = new Instructor[] { Bob, Sally, Dave, Jill };

            English.Head = Jill;

            Math.Head = Sally;

            Student billy = new Student("Billy", new DateTime(2000, 2, 8));
            Student joe = new Student("Joe", new DateTime(2001, 5, 22));
            Student sarah = new Student("Sarah", new DateTime(2003, 8, 21));
            Student jack = new Student("Jack", new DateTime(2002, 11, 14));

            Student[] students = new Student[] { billy, joe, sarah, jack };

            eng101.AddStudent(billy);
            eng101.AddStudent(joe);
            eng101.AddStudent(sarah);
            billy.AddCourse(eng101.Title, 'B');
            joe.AddCourse(eng101.Title, 'A');
            sarah.AddCourse(eng101.Title, 'C');

            eng254.AddStudent(joe);
            eng254.AddStudent(jack);
            joe.AddCourse(eng254.Title, 'C');
            jack.AddCourse(eng254.Title, 'B');

            math101.AddStudent(sarah);
            math101.AddStudent(jack);
            math101.AddStudent(joe);
            sarah.AddCourse(math101.Title, 'A');
            jack.AddCourse(math101.Title, 'B');
            joe.AddCourse(math101.Title, 'B');

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine($"Course: {courses[i].Title}, Students: ");
                courses[i].PrintStudents();
                Console.WriteLine();
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Student: {students[i].name}, Age: {students[i].GetAge()}, GPA: {students[i].GetGPA()}");
            }
            Console.WriteLine();

            for (int i = 0; i < instructors.Length; i++)
            {
                Console.WriteLine($"Instructor: {instructors[i].name}, Age: {instructors[i].GetAge()}, Salary: {instructors[i].GetSalary(24.75)}");
            }


            return 0;
        }
    }
    
}