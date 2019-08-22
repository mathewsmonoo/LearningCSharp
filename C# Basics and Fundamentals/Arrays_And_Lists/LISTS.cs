using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_And_Lists
{
    class LISTS
    {
        public static void ListExamples()
        {
            //Lists have dynamic size
            var numbers = new List<int>();
            // The < > indicates that List is a GENERIC TYPE , 
            // ...where inside < > you specify any type.

            // To initialize a list:
            var numbers2 = new List<int>() { 1, 2, 3, 4, 5 };

            // Useful Methods : Add, AddRange, Remove,
            // ...RemoveAt, IndexOf, Contains, Count . 
            numbers2.Add(1); //Add
            numbers2.Add(2); //Add

            numbers2.AddRange(new int[3] { 20,21,22 } ); //AddRange
                             //initializing a array inside ()

            foreach (var number in numbers2){
                Console.WriteLine(number);
            }

            //IndexOf()    -> start search from beg. of list
            Console.WriteLine("IndexOf()");
            Console.WriteLine("\tIndex of 1: " + numbers2.IndexOf(1));
            //LastIndexOf() -> start search from end of list
            Console.WriteLine("\tLAST Index of 1: " + numbers2.LastIndexOf(1));

            //Count
            Console.WriteLine("Count: " + numbers2.Count());

            //Remove -> Removes only first appearance of said element

            numbers2.Remove(1);

            Console.WriteLine("After Remove:");
            foreach (var number in numbers2)
            {
                Console.WriteLine("\t" + number);
            }

            //....Remove pt.2:
            // IN C# IT IS NOT POSSIBLE TO REMOVE ELEMENTS
            //..FROM A LIST USING 'FOREACH' 
            for (int i = 0; i < numbers2.Count; i++)
            {
                if (numbers2[i] == 1)
                    numbers2.Remove(1);
            }

            Console.WriteLine("After Remove with for");
            foreach (var number in numbers2)
            {
                Console.WriteLine("\t" + number);
            }

            //Clear
            Console.WriteLine("Before Clear:");
            Console.WriteLine("\t# of elements : " + numbers2.Count);
            numbers2.Clear();
            Console.WriteLine("After Clear:");
            Console.WriteLine("\t# of elements : " + numbers2.Count);


        }
    }
}
