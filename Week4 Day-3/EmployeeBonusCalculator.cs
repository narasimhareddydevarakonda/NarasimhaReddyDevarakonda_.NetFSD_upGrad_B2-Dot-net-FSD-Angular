using System;
namespace MyProjects
{
    internal class EmployeeBonusCalculator
    {
        static void Main()
        {
            Console.WriteLine("Enter Name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter salary");
            var sal= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Experience");
            var exp=Convert.ToByte(Console.ReadLine());


            if (exp < 2)
                Console.WriteLine($"Final salary after bonus {sal += (sal * 0.05)}");
            else if (exp>2 && exp<5)
                Console.WriteLine($"Final salary after bonus {sal += (sal *0.1 )}");
            else
                Console.WriteLine($"Final salary after bonus {sal += (sal * 0.15)}");
        }
    }
}
