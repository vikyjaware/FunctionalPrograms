using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class PrimeFactors
    {
        public void factor()
        {
            Console.WriteLine("Enter the number to find prime factors ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime factors of number " + num + " are");
            for (int i = 2; i <= num; i++)
            {
                bool flag = false;
                if (num % i == 0)
                {
                    flag = true;
                    for (int j = 2; j < i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = false;
                        }
                    }
                }
                if (flag == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
