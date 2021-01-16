using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            string course1 = "c#";
            string course2 = "c++";
            string course3 = "java";

            Console.WriteLine(course1);

            string[] courses = { "c#", "c++", "java" };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("For finish.");

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
        }
    }
}
