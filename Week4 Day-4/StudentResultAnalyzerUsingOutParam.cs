using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Day_4
{
    internal class StudentResultAnalyzerUsingOutParam
    {
        public static void CalculateResult(int marks1, int marks2, int marks3, out int Total, out double Average)
        {
            Total = marks1 + marks2 + marks3;
            Average = Total / 3.0;
        }

        static int GetValidMarks()
        {
            int marks;

            while (true)
            {
                marks = Convert.ToInt32(Console.ReadLine());

                if (marks >= 0 && marks <= 100)
                    return marks;

                Console.Write("Invalid marks! Enter marks between 0 and 100: ");
            }
        }

        static void Main()
        {
            char choice;

            do
            {
                int marks1, marks2, marks3, Total;
                double Average;

                Console.Write("Enter marks1 (0-100): ");
                marks1 = GetValidMarks();

                Console.Write("Enter marks2 (0-100): ");
                marks2 = GetValidMarks();

                Console.Write("Enter marks3 (0-100): ");
                marks3 = GetValidMarks();

                CalculateResult(marks1, marks2, marks3, out Total, out Average);

                Console.WriteLine("Total Marks: " + Total);
                Console.WriteLine("Average Marks: " + Average);

                if (Average >= 40)
                {
                    Console.WriteLine("Result: Pass");
                }
                else
                {
                    Console.WriteLine("Result: Fail");
                }

                Console.Write("Do you want to enter another student marks? (y/n): ");
                choice = Convert.ToChar(Console.ReadLine());

            } while (choice == 'y' || choice == 'Y');
        }
    }
}