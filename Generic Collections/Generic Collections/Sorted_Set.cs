using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    public class Sorted_Set
    {

        public void SortedSet_Test()
        {
            SortedSet<int> integerSortedSet = new SortedSet<int>();

            integerSortedSet.Add(66);
            integerSortedSet.Add(55);
            integerSortedSet.Add(88);
            integerSortedSet.Add(22);
            integerSortedSet.Add(77);
            integerSortedSet.Add(11);

            //Addind Duplicate Elements
            integerSortedSet.Add(55);
            integerSortedSet.Add(11);

            foreach (int item in integerSortedSet)
            {
                Console.Write(item + " ");
            }


            //SortedSet<Customer> customers = new SortedSet<Customer>();


            //Customer customer1 = new Customer()
            //{
            //    ID = 1,
            //    Name = "Kavinda",
            //    Age = 29,
            //    City = "Alawwa",
            //    Weight = 100.5m,
            //    MaridStatus = true,
            //    designation = Designation.Software_Engineer

            //};
            //Customer customer2 = new Customer()
            //{
            //    ID = 2,
            //    Name = "Buddhika",
            //    Age = 26,
            //    City = "Colombo",
            //    Weight = 85.5m,
            //    MaridStatus = false,
            //    designation = Designation.Business_Analysis

            //};

            //customers.Add(customer1);
            //customers.Add(customer2);



            //Console.WriteLine();
            //Console.WriteLine();

            //foreach (var item in customers)
            //{
            //    Console.WriteLine($"{item.ID} ");
            //    Console.WriteLine($"{item.Name} ");
            //    Console.WriteLine($"{item.Age} ");
            //    Console.WriteLine($"{item.City} ");
            //    Console.WriteLine($"{item.Weight} ");
            //    Console.WriteLine($"{item.MaridStatus} ");
            //    Console.WriteLine($"{item.designation} ");
            //    Console.WriteLine();
            //}
        }
    }
}
