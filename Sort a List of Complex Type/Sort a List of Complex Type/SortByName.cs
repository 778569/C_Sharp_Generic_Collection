using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_a_List_of_Complex_Type
{
    public class SortByName : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
