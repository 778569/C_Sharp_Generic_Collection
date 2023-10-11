using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List_Collection
{
    public class Create_List
    {

        public void Test()
        {
            //List<string> countries = new List<string>();

            ////Adding a values

            //countries.Add("India");
            //countries.Add("USA");

            //foreach (var item in countries)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine("");
            //Console.WriteLine("");
            //List<string> newCountries = new List<string>();
            //newCountries.Add("SriLanka");
            //newCountries.Add("UK");

            ////Add Range
            
            //countries.AddRange(newCountries);

            //foreach (var item in countries)
            //{
            //    Console.WriteLine(item);
            //}

            ////Accessing the List

            //var FirstElement = countries[0];
            //var SecondElement = countries[1];
            //var ThirdElement = countries[2];

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine(FirstElement);
            //Console.WriteLine(SecondElement);
            //Console.WriteLine(ThirdElement);

            //Console.WriteLine();
            //Console.WriteLine();


            List<string> countries2 = new List<string>() 
            { 
                "India",
                "SriLanka",
                "Pakistan",
                "UK",
                "USA",
                "Japan",
                "China",
                "New Zeland",
                "India",
                "SriLanka",
                "UK"
            
            };

            foreach (var item in countries2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();


            countries2.Clear();

            foreach (var item in countries2)
            {
                Console.WriteLine("Item " + item);
            }
            Console.WriteLine("End");
            //countries2.RemoveRange(0 , 2); // 0,1 Removed "india","SriLanka"

            //countries2.RemoveAll(x => x.Length <= 3); //remove UK

            //countries2.RemoveAll(x => x.Length <3); //remove UK

            //Console.WriteLine();
            //Console.WriteLine();

            //var Check_Contains_Ind = countries2.Contains("India");
            //Console.WriteLine(Check_Contains_Ind);

            //var Check_Contains_USA = countries2.Contains("USA");
            //Console.WriteLine(Check_Contains_USA);
        }
    }
}
