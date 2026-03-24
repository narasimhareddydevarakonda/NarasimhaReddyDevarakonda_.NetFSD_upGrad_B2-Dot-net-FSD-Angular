using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Day_1_Ds
{
    internal class StackBasedUndoSystem
    {
        static void Main()
        {
            Stack<string> int_stack = new Stack<string>();
            int_stack.Push("Type A");
            int_stack.Push("Type B");
            int_stack.Push("Type C");
            int_stack.Pop();
            int_stack.Pop();

            foreach (var item in int_stack)
            {
                Console.Write($"Current State After Operations:{item}");
            }


        }
    }
}
