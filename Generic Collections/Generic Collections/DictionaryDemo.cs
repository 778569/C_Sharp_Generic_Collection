using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    public class DictionaryDemo
    {

        public void Test()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");
            dictionary.Add(4, "Four");
            dictionary.Add(5, "Five");


            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine("Key : " + item.Key + " , " + item.Value);
            }
        }
    }
}
