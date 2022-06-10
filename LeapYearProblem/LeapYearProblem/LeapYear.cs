using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearProblem
{
    public class LeapYear
    {
        public void YearLeap()
        {
            int Year;
            Console.WriteLine("Enter a Year");
            Year = int.Parse(Console.ReadLine());
            if (Year > 999)
            {
                if (Year % 4 == 0 && Year % 100 != 0 || Year % 400 == 0)
                {
                    Console.WriteLine("Entered Year is Leap Year");
                }
                else
                {
                    Console.WriteLine("Entered Year is not a Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Please Enter a Year in Four digit");
                Console.WriteLine("Enter a Year");
                Year = int.Parse(Console.ReadLine());
                if (Year % 4 == 0 && Year % 100 != 0 || Year % 400 == 0)
                {
                    Console.WriteLine("Entered Year is Leap Year");
                }
                else
                {
                    Console.WriteLine("Entered Year is not a Leap Year");
                }
            }
        }
    }
}