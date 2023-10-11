using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List_Collection
{
    public class CopyList
    {
        public void Test()
        {

            string[] array = new string[]
            {
                "India",
                "Sri Lanka",
                "Pakistan"
            };
            // Copy the array to a list

            List<string> copidList = new List<string>(array);

            Console.WriteLine("Copid from array to List");

            foreach (var item in copidList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
