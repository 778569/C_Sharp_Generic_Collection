using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    public class Hash_Set
    {

        public void Test_HashSet()
        {
            HashSet<int> intHashSet = new HashSet<int>();

            intHashSet.Add(11);
            intHashSet.Add(22);
            intHashSet.Add(55);
            intHashSet.Add(65);

            intHashSet.Add(55);

            foreach (int item in intHashSet)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
