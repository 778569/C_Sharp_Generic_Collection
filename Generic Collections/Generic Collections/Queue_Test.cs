using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    public class Queue_Test
    {

        public void Test()
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("India");
            queue.Enqueue("USA");
            queue.Enqueue("UK");
            queue.Enqueue("China");
            queue.Enqueue("Nepal");
            queue.Enqueue("Sri Lanka");


            foreach (string item in queue)
            {
                Console.Write($"{item} "); // First in First OUT
            }

            Console.WriteLine();


            Console.WriteLine("Peek Element " + queue.Peek()); // Removing First Eelement (India)
            Console.WriteLine();

            Console.WriteLine("Pop Element " + queue.Dequeue());
            Console.WriteLine();

            foreach (string item in queue)
            {
                Console.Write($"{item} ");
            }

        }


    }
}

