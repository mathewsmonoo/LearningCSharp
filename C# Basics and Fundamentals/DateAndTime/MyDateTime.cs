using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class MyDateTime
    {
        public static void HowTo()
        {
            var dateTime = new DateTime(2019, 1, 1);
            var timeNow = DateTime.Now;
            var today = DateTime.Today;

            // Console.WriteLine("Hour   : " + timeNow.Hour);
            // Console.WriteLine("Minute : " + timeNow.Minute);

            var tomorrow = timeNow.AddDays(1);
            var yesterday = timeNow.AddDays(-1);

            Console.WriteLine(timeNow.ToLongDateString());
            Console.WriteLine(timeNow.ToShortDateString());
            Console.WriteLine(timeNow.ToLongTimeString());
            Console.WriteLine(timeNow.ToShortDateString());
            Console.WriteLine(timeNow.ToString());
            Console.WriteLine(timeNow.ToString("yyyy/MM/dd HH:mm"));

        }
    }
}
