using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_And_Lists
{
    class EXERCISES
    {
        public static void Exercise_1() {
            /*
            When you post a message on Facebook, depending on the number of people who like your post, 
            Facebook displays different information.
            >If no one likes your post, it displays that no one liked your post.
            >If only one person likes your post, it displays: [Friend's Name] likes your post.
            >If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            >If more than two people like your post, it displays: [Friend 1], [Friend 2] 
             and[Number of Other People] others like your post.
            */
            Console.WriteLine("\n\tEXERCISE 1");
            var user_list = new List<string>();

            while (true)
            {
                Console.WriteLine($"Insert name of user who liked your post..:");
                string insert_name = Console.ReadLine();

                if (insert_name.Length == 0) // Checks if user_input is ENTER (which returns string of len 0 )
                    break; // exits while(true)
                else
                    user_list.Add(insert_name);
            }

            switch (user_list.Count)
            {
                case 0:
                    Console.WriteLine("No one liked your post :(");
                    break;
                case 1:
                    Console.WriteLine($"{user_list[0]} Liked your post.");
                    break;
                case 2:
                    Console.WriteLine($"{user_list[0]} and {user_list[1]} Liked your post.");
                    break;
                default:
                    Console.WriteLine($"{user_list[0]} and {user_list.Count - 1 } more users like your post.");
                    // (...) and {} needs -1 because the first user is already printed.
                    break;
            }

            Console.WriteLine("\n---------------------------------------------------------------");
        }

        public static void Exercise_2() {
            /*Write a program and ask the user to enter their name. Use an array to reverse the 
             name and then store the result in a new string.Display the reversed name on the console.*/
            Console.WriteLine("\n\tEXERCISE 2");

            Console.WriteLine("Insert your name....:");
            string user_input2 = Console.ReadLine();
            char[] ex2array = user_input2.ToCharArray(); // converts string to array
            Array.Reverse(ex2array);
            Console.WriteLine("Your name Reversed: ");
            Console.WriteLine(ex2array);
            Console.WriteLine("\n---------------------------------------------------------------");
        }

        public static void Exercise_3() {
            /* Write a program and ask the user to enter 5 numbers. If a number has been 
               previously entered, display an error message and ask the user to re-try. 
               Once the user successfully enters 5 unique numbers, sort them and display 
               the result on the console.*/
            Console.WriteLine("\n\tEXERCISE 3");

            var ex3list = new List<int>();

            while (ex3list.Count() < 5)
            {
                Console.WriteLine("Insert number:");
                int user_input3 = Convert.ToInt32(Console.ReadLine()); //converting user input to int32

                if (ex3list.Contains(user_input3))
                {
                    Console.WriteLine("Number already inserted, try again.\n");
                }
                else
                {
                    ex3list.Add(user_input3);
                    Console.WriteLine(user_input3 + " added succesfully.\n");
                }
            }

            Console.WriteLine("Your numbers are:");
            foreach (var _ in ex3list)
            {
                Console.WriteLine("\t" + _);
            }

            Console.WriteLine("\n---------------------------------------------------------------");

        }

        public static void Exercise_4()
        {
            /*Write a program and ask the user to continuously enter a number 
             or type "Quit" to exit. The list of numbers may include duplicates.
             Display the unique numbers that the user has entered.*/
            Console.WriteLine("\n\tEXERCISE 4");

            var ex4list = new List<int>();

            while (true)
            {
                Console.WriteLine("Insert a number or type 'Quit' to quit...");
                var user_input4 = Console.ReadLine();
                user_input4.ToLower();
                if (user_input4 =="quit")
                //if (user_input4 == "Quit" || user_input4 == "quit" || user_input4 == "QUIT")
                {
                    Console.WriteLine("Exiting Ex4 ....");
                    break;
                }
                else
                {
                    int user_input4checked = Convert.ToInt32(user_input4);
                    if (!(ex4list.Contains(user_input4checked)))
                    {
                        ex4list.Add(user_input4checked);
                    }
                }
            }

            Console.WriteLine("\nNumbers you've inserted...:");
            foreach (var _ in ex4list)
            {
                Console.WriteLine("\t" + _);
            }

            Console.WriteLine("\n---------------------------------------------------------------");
        }

        /* 
         * NOT 
         * YET 
         * FINISHED
        */
        public static void Exercise_5() /* NOT YET FINISHED */
        {
            /*Write a program and ask the user to supply a list of comma separated numbers 
             (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, 
             display "Invalid List" and ask the user to re-try; otherwise, display 
             the 3 smallest numbers in the list.*/
            Console.WriteLine("\n\tEXERCISE 5");
            while (true) { 
                Console.WriteLine("Insert 5 numbers separated by comma");
                Console.WriteLine("Example: 1,2,3,4,5");
                var user_input5 = Console.ReadLine();
                char[] ex5array = user_input5.ToCharArray();
                    if (user_input5.Length > 9 || user_input5.Length == 0)
                    {
                        Console.WriteLine("Invalid list, please retry.");
                    }
                    else
                    {
                        var ex5arraychecked = new List<int>();
                        foreach (var _ in ex5array)
                        {
                            if (_ != ',')
                            {
                                ex5arraychecked.Add(Convert.ToInt32(_));
                            }
                        }
                        //ex5arraychecked.Sort();
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("\t" + ex5arraychecked[i]);
                        }
                        break;
                }
            }
            Console.WriteLine("\n---------------------------------------------------------------");
        }
    }
}
