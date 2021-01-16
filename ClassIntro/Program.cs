using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.Name = "c#";
            course1.Teacher = "Engin Demiroğ";
            course1.WatchRate = 68;

            Course course2 = new Course();
            course2.Name = "Java";
            course2.Teacher = "Kerem Varış";
            course2.WatchRate = 64;

            Course course3 = new Course();
            course3.Name = "Python";
            course3.Teacher = "Berkay Bilgin";
            course3.WatchRate = 80;

            Console.WriteLine(course1.Name + " : " + course1.Teacher);
            Console.WriteLine(course2.Name + " : " + course2.Teacher);
            Console.WriteLine(course3.Name + " : " + course3.Teacher);

            Course[] courses = { course1, course2, course3 };
            foreach (var course in courses)
            {
                Console.WriteLine(course.Name + " : " + course.Teacher);
            }
        }
    }

    class Course
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public int WatchRate { get; set; }
    }
}
