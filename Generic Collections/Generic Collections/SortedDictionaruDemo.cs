using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    public class SortedDictionaruDemo
    {
        public void Test()
        {
            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();

            sortedDictionary.Add(1 ,"One");
            sortedDictionary.Add(5, "Five");
            sortedDictionary.Add(7, "Seven");
            sortedDictionary.Add(2, "Two");
            sortedDictionary.Add(3, "Three");

            foreach (KeyValuePair<int, string> item in sortedDictionary)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
    }
}
