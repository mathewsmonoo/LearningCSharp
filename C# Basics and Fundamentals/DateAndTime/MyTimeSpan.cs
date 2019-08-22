using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class MyTimeSpan
    {
        public static void HowTo()
        {
            /*-----------
               Creating 
             ----------*/
            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine($"cw timeSpan obj: {timeSpan}");
            //var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan1 = TimeSpan.FromHours(1);

            // If you have 2 datetime objects and you subtract them, the result is a timespan.

            var start    = DateTime.Now;
            var end      = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine($"Duration = {duration}\n");

            /*-----------
              Properties
             -----------*/

            Console.WriteLine($"Minutes      : {timeSpan.Minutes}");
            Console.WriteLine($"Total Minutes: {timeSpan.TotalMinutes}\n");
            // the above line prints 1 hour + 2 minutes + 3 seconds, 
            // converted to MINUTES => 62.05
                

            /*-------------
             Add & Subtract
             -------------*/

            Console.WriteLine($"Add Example      : { timeSpan.Add(TimeSpan.FromMinutes(8))}");
            Console.WriteLine($"Subtract Example : { timeSpan.Subtract(TimeSpan.FromMinutes(2))}\n");

            /*-------------------
             ToString and Parse
             -------------------*/

            Console.WriteLine($"ToString Example : {timeSpan.ToString()}");

            Console.WriteLine($"Parse Example    : {TimeSpan.Parse("01:02:03")}");

        }
    }
}