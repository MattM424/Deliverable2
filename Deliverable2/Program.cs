using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            //has user input first date
            Console.Write("Enter date that's bigger than the second (yyyy-MM-dd): ");
            var strDate1 = Console.ReadLine();

            //has user input second date
            Console.Write("Enter date that's smaller than the first (yyyy-MM-dd): ");
            var strDate2 = Console.ReadLine();

            //Takes inputs and converts them to usable dates
            var date1 = DateTime.Parse(strDate1);
            var date2 = DateTime.Parse(strDate2);

            //Calculates the difference between the dates given
            var difference = date1 - date2;

            //Displays the differences in years, months, days, hours, minutes and seconds
            Console.WriteLine($"Difference in years: {difference.TotalDays / 365}");
            Console.WriteLine($"Difference in months: {difference.TotalDays / 365 * 12}");
            Console.WriteLine($"Difference in days: {difference.TotalDays}");
            Console.WriteLine($"Difference in hours: {difference.TotalHours}");
            Console.WriteLine($"Difference in minutes: {difference.TotalMinutes}");
            Console.WriteLine($"Difference in seconds: {difference.TotalSeconds}");
            Console.ReadKey();
        }
    }
}
