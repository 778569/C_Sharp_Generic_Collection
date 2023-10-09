using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    public class Stack_Test
    {

        public void Test()
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("India");
            stack.Push("USA");
            stack.Push("UK");
            stack.Push("China");
            stack.Push("Nepal");
            stack.Push("Sri Lanka");

            
            foreach (string item in stack)
            {
                Console.Write($"{item} "); // Last in First OUT
            }

            Console.WriteLine();


            Console.WriteLine("Peek Element " + stack.Peek()); // Removing Last Eelement (Sri lanka)
            Console.WriteLine();

            Console.WriteLine("Pop Element " + stack.Pop());
            Console.WriteLine();

            foreach (string item in stack)
            {
                Console.Write($"{item} ");
            }

        }


    }
}
