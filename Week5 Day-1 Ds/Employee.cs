using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Day_1_Ds
{
    internal class Employee
    {
      
          public int EmpId { get; set; }
            public string Name { get; set; }

            public Employee(int id, string name)
            {
                EmpId = id;
                Name = name;
            }
        }
    }

