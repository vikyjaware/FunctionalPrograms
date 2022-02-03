using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class LeapYear
    {
        public void year()
        {
			Console.WriteLine("Enter any year to check wheather it is leap or not ");
			int year = Convert.ToInt32(Console.ReadLine());
			if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
			{
				Console.WriteLine("The " + year + " is a leap year");
			}
			else
			{
				Console.WriteLine("The " + year + " is NOT a leap year");
			}
		}
    }
}
