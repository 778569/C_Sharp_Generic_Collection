using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Generic_List_Collection
{
    public class SortReverse_List
    {

        public void Test()
        {
            //List<int> numberList = new List<int>() { 1, 8, 7, 5, 2 };

            ////numberList.Sort();

            ////foreach (var item in numberList)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //Console.WriteLine();
            //numberList.Reverse();

            //foreach (var item in numberList)
            //{
            //    Console.WriteLine(item);
            //}



            List<string> names = new List<string>() { "Pranaya", "Anurag", "Sambit", "Hina", "Rakesh" };

            names.Sort();

            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);    

            //}


            names.Reverse();

            foreach (var item in names)
            {
                Console.WriteLine(item);

            }

        }

        
    }
}
