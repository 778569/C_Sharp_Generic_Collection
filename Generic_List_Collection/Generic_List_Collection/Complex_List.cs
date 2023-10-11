using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List_Collection
{
    public class Complex_List
    {
        public void Test()
        {
            // Create Employee Objects
            Employee emp1 = new Employee() { ID = 1, Name = "Kavinda", Gender = "Male", designation = Designation.SE , Salary = 90000};

            Employee emp2 = new Employee() { ID = 2, Name = "Buddhikaa", Gender = "Female", designation = Designation.BA, Salary = 70000 };

            Employee emp3 = new Employee() { ID = 3, Name = "Bandara", Gender = "Male", designation = Designation.QA, Salary = 60000 };

            Employee emp4 = new Employee()
            {
                ID = 4,
                Name = "Santha",
                Gender = "Male",
                designation = Designation.SE,
                Salary = 100000
            };

            // Create a Generic List of type Employee
            List<Employee> listEmployee = new List<Employee>()
            {
                emp1,
                emp2,
                emp3,
                emp4
            };

            // Invoke TrimExcess() to set the capacity to the actual number of elements in the List


            listEmployee.TrimExcess();

            Console.WriteLine($"\nList Capacity After invoking TrimExcess: {listEmployee.Capacity} ");




            //// ReadOnlyCollection will not have Add() or Remove() methods

            //ReadOnlyCollection<Employee> readOnlyEmployees = listEmployee.AsReadOnly();

            //Console.WriteLine($"\nTotal Items in ReadOnlyCollection: {readOnlyEmployees.Count}");





            //var True_For_All = listEmployee.TrueForAll(x=> x.Salary >= 5000);

            //Console.WriteLine($"Are all salaries greater than 5000: {True_For_All}");

            //var True_For_All_gender = listEmployee.TrueForAll(x => x.Gender == "Male");

            //Console.WriteLine($"Are all salaries greater than 5000: {True_For_All_gender}");


            //var Find_Index =  listEmployee.FindLastIndex(x => x.ID == 2);

            //Console.WriteLine(Find_Index);

            //Console.WriteLine();

            //var Find_Emp_Name = listEmployee.FindLastIndex(x => x.Gender == "Male");

            //Console.WriteLine(Find_Emp_Name);



            // Use FindAll() method, elements from a list that matches the conditions specified by a predicate.

            //List<Employee> filteredEmployees = listEmployee.FindAll(employee=> employee.Gender == "Male");

            //foreach (var item in filteredEmployees)
            //{
            //    Console.WriteLine("Id: " + item.ID);
            //    Console.WriteLine("Name: " + item.Name);
            //    Console.WriteLine("Salary: " + item.Salary);
            //    Console.WriteLine("Designation: " + item.designation);
            //    Console.WriteLine("Gender: " + item.Gender);
            //    Console.WriteLine( );
            //}


            // ethod Name StartsWith P /// True or false

            //bool Check_Name_Start_Letter = listEmployee.Exists(e => e.Name.StartsWith("B"));

            //Console.WriteLine(Check_Name_Start_Letter);

            //bool Check_Name_Start_Letter_Z = listEmployee.Exists(e => e.Name.StartsWith("Z"));

            //Console.WriteLine(Check_Name_Start_Letter_Z);




            //Check Contains - 

            //var Epm1_Check = listEmployee.Contains(emp1);
            //Console.WriteLine(Epm1_Check);
            //var Epm4_Check = listEmployee.Contains(emp4);
            //Console.WriteLine(Epm4_Check);



            //Adding Employees to the listEmployees collection using Add Method
            //listEmployee.Add(emp1);
            //listEmployee.Add(emp2);
            //listEmployee.Add(emp3);



            //Retrieving Items from the collection by using Index. 
            //The following line of code will retrieve the employee from the list. 
            //The List index is  0 based.

            //Employee FirstEmployee = listEmployee[0];

            //Console.WriteLine("Id: " + FirstEmployee.ID);
            //Console.WriteLine("Name: " + FirstEmployee.Name);
            //Console.WriteLine("Salary: " + FirstEmployee.Salary);
            //Console.WriteLine("Designation: " + FirstEmployee.designation);
            //Console.WriteLine("Gender: " + FirstEmployee.Gender);

            ////Fetch the First Added Employee from the Collection
            //Console.WriteLine();
            //Console.WriteLine();
            ///////////////////

            //for (int i = 0; i < listEmployee.Count; i++)
            //{
            //    Employee employee = listEmployee[i];


            //    Console.WriteLine("Id: " + employee.ID);
            //    Console.WriteLine("Name: " + employee.Name);
            //    Console.WriteLine("Salary: " + employee.Salary);
            //    Console.WriteLine("Designation: " + employee.designation);
            //    Console.WriteLine("Gender: " + employee.Gender);

            //    Console.WriteLine();
            //}


            //foreach (var item in listEmployee)
            //{
            //    Console.WriteLine("Id: " + item.ID);
            //    Console.WriteLine("Name: " + item.Name);
            //    Console.WriteLine("Salary: " + item.Salary);
            //    Console.WriteLine("Designation: " + item.designation);
            //    Console.WriteLine("Gender: " + item.Gender);

            //    Console.WriteLine();
            //}

            //Employee emp4 = new Employee()
            //{
            //    ID = 4,
            //    Name = "Santha",
            //    Gender = "Male",
            //    designation = Designation.SE,
            //    Salary = 100000
            //};

            //listEmployee.Insert(0, emp4);

            //foreach (var item in listEmployee)
            //{
            //    Console.WriteLine("Id: " + item.ID);
            //    Console.WriteLine("Name: " + item.Name);
            //    Console.WriteLine("Salary: " + item.Salary);
            //    Console.WriteLine("Designation: " + item.designation);
            //    Console.WriteLine("Gender: " + item.Gender);

            //    Console.WriteLine();
            //}

            //Console.WriteLine("Index number : "+listEmployee.IndexOf(emp4)); 
        }
    }
}
