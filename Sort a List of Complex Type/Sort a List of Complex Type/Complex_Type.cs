using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_a_List_of_Complex_Type
{
    public class Complex_Type
    {
        public void test()
        {
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee() { ID = 101, Name = "Pranaya", Gender = "Male", Salary = 5000 },
                new Employee() { ID = 102, Name = "Priyanka", Gender = "Female", Salary = 7000 },
                new Employee() { ID = 103, Name = "Anurag", Gender = "Male", Salary = 5500 },
                new Employee() { ID = 104, Name = "Sambit", Gender = "Male", Salary = 6500 },
                new Employee() { ID = 105, Name = "Hina", Gender = "Female", Salary = 6500 }
            };


            Console.WriteLine("Employees Before Sorting");

            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}," +
                    " Name = {1}," +
                    "  Gender = {2}," +
                    " Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }

            //SortByName sortByName = new SortByName();
            //listEmployees.Sort(sortByName);

            listEmployees = listEmployees.OrderBy(x =>x.Name).ToList();

            Console.WriteLine();
            foreach (var item in listEmployees)
            {
                Console.WriteLine("ID = {0} " + "Name = {1} " + "Gender = {2} " + "Salary = {3} ", item.ID, item.Name,item.Gender,item.Salary);
                
                
            }
        }
    }
}
