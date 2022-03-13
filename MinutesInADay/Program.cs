using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinutesInADay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n===|= Minutes - calculator =|===\n");

            Console.WriteLine(CalculateMinutes(day: 65, hours: 15, minutes: 6, seconds: 3));

            Console.ReadLine();
        }

        private static string CalculateMinutes(int day, int hours, int minutes, int seconds)
        {
            if (day >= 0 && (hours > 0 && hours <= 24) && (minutes > 0 && minutes <= 60) && (seconds > 0 && seconds <= 60))
            {
                int totalMinutes = (seconds * minutes) * hours;

                DateTime date = DateTime.Now.AddDays(day);

                switch (date.Month)
                {
                    case (int)Months.Jan:
                        return $"{date.ToLongDateString()} has a total of {totalMinutes} minutes according to supplied parameters.";

                    case (int)Months.Feb:
                        return $"{date.ToLongDateString()} has a total of {totalMinutes} minutes according to supplied parameters.";

                    case (int)Months.Mar:
                        return $"{date.ToLongDateString()} has a total of {totalMinutes} minutes according to supplied parameters.";

                    case (int)Months.Apr:
                        return $"{date.ToLongDateString()} has a total of {totalMinutes} minutes according to supplied parameters.";

                    case (int)Months.May:
                        return $"{date.ToLongDateString()} has a total of {totalMinutes} minutes according to supplied parameters.";

                    case (int)Months.Jun:
                        return $"{date.ToLongDateString()} has a total of {totalMinutes} minutes according to supplied parameters.";

                    case (int)Months.Jul:
                        return $"{date.ToLongDateString()} has a total of {totalMinutes} minutes according to supplied parameters.";

                    case (int)Months.Aug:
                        return $"{date.ToLongDateString()} has a total of {totalMinutes} minutes according to supplied parameters.";

                    case (int)Months.Sep:
                        return $"{date.ToLongDateString()} has a total of {totalMinutes} minutes according to supplied parameters.";

                    case (int)Months.Oct:
                        return $"{date.ToLongDateString()} has a total of {totalMinutes} minutes according to supplied parameters.";

                    case (int)Months.Nove:
                        return $"{date.ToLongDateString()} has a total of {totalMinutes} minutes according to supplied parameters.";

                    case (int)Months.Dec:
                        return $"{date.ToLongDateString()} has a total of {totalMinutes} minutes according to supplied parameters.";

                    default:
                        return "Month is out of scope.";
                }
            }

            return "Parameters are out of bounds.";
        }

        private enum Months
        { 
            Jan = 1,
            Feb,
            Mar,
            Apr,
            May,
            Jun,
            Jul,
            Aug,
            Sep,
            Oct,
            Nove,
            Dec
        }
    }
}
