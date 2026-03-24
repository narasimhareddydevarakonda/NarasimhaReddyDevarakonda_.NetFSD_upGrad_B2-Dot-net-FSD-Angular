using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Day_1
{
    internal class EmployeeImplementation
    {
        static void Main()
        {
            Manager m = new Manager("John", 50000);
            Developer d = new Developer("Alex", 40000);
            Console.WriteLine("Manager Salary: " + m.CalculateSalary());
            Console.WriteLine("Developer Salary: " + d.CalculateSalary());
        }




    }
}

