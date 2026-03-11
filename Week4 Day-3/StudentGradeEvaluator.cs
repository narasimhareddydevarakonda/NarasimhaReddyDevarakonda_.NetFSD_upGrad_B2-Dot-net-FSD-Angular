using System;

namespace MyProjects
{
    internal class StudentGradeEvaluator
    {
        static void Main()
        {
            Console.WriteLine($"Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine($"Enter Marks");
            var marks = Convert.ToSByte(Console.ReadLine());


            if (marks > 0 || marks < 100)
            {
                if (marks >= 90)
                    Console.WriteLine($"Grade : A");
                else if (marks >= 70)
                    Console.WriteLine($"Grade : B");
                else if (marks >= 50)
                    Console.WriteLine($"Grade : C");
                else if (marks > 35)
                    Console.WriteLine($"Grade : D");
                else
                    Console.WriteLine("FAIL");
            }
            else
                Console.WriteLine("Enter Valid Marks");
        }
    }
}
