using System;

namespace Week4Day_4
{
    internal class StudentGradeCalculator
    {
        public double CalculateAverage(int m1, int m2, int m3)
        {
            return (m1 + m2 + m3) / 3;
        }
       

        static void Main()
        {
            StudentGradeCalculator stu=new StudentGradeCalculator();
            Console.WriteLine("Enter three numbers");
            int m1 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());
            int m3 = Convert.ToInt32(Console.ReadLine());
            var average = stu.CalculateAverage(m1,m2,m3);
            Console.WriteLine($"Average :  {average}");

            if (average > 90)
                Console.WriteLine("Grade = O");
            else if (average > 75)
                Console.WriteLine("Grade = A");
            else if (average > 50)
                Console.WriteLine("Grade = B");
            else if (average > 36)
                Console.WriteLine("Grade = C");
            else Console.WriteLine("Grade = F");

        }

    }
}
