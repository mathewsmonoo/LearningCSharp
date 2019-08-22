using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_And_Lists
{
    class ARRAYS
    {
        public static void ArrayExamples()
        {
            var numbers = new int[] { 2,8,10,0,8,4,78,6 };

            //LENGTH -> Returns SIZE of ARRAY
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 3);
            Console.WriteLine("Index of 3: "+ index);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Clear()
            //Array.Clear(array,index,length);
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effects of Clear() : ");
            foreach (var n  in numbers)
            {
                Console.WriteLine(n);
            }

            //Copy()
            //Array.Copy(first_array, destination_array, number of elements)
            var numbers2 = new int[3];
            Array.Copy(numbers, numbers2, 3);
            Console.WriteLine("Effects of Copy() : ");
            foreach (var n in numbers2)
            {
                Console.WriteLine(n);
            }

            //Sort
            //Array.Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effects of Sort() : ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Reverse
            //Array.Reverse(array1)
            Array.Reverse(numbers);
            Console.WriteLine("Effects of Reverse() : ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Notes:
            //Array.method() IS A STATIC METHOD

        }
    }
}
