using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_a_List_of_Complex_Type
{
    public class Employee : IComparable<Employee>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }


        public Employee()
        {

            this.Salary = Salary;
        }
        public int CompareTo(Employee? obj)
        {
            if (Salary > obj.Salary)
            {
                return 1;
            }

            else if (Salary < obj.Salary)
            {
                return-1;
            }
            else
            {
                return 0;
            }

        }
    }
}
