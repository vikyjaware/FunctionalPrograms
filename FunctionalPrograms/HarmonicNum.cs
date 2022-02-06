using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class HarmonicNum
    {
        public void harmonic()
        {
            int i, N;
            double num = 0.0;
            Console.WriteLine("Enter the Nth number to get the harmonic number");
            N = Convert.ToInt32(Console.ReadLine());
            if (N != 0)
            {
                for (i = 1; i <= N; i++)
                {
                    Console.Write("1/{0} ", i);
                    num += 1 / (float)i;
                }
                Console.WriteLine("\nThe sum of " +N+ " harmonic numbers is " + num);
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
