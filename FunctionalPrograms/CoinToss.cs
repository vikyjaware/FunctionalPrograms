using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class CoinToss
    {
        public void toss()
        {
            int head = 0, tail = 0;
            double toss = 0,PercentHead,PercentTail;
            Console.WriteLine("Enter the number of times you want to flip the coin ");
            int num =Convert.ToInt32 (Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
            Random rand = new Random();
               toss=rand.NextDouble();
                if(toss<0.5)
                    head++;
                else
                    tail++;
            }
            PercentHead =100*head/num;
            PercentTail =100*tail/num;
            Console.WriteLine("Perrcentage of head is " + PercentHead + "\nPercentage of tail is " + PercentTail);
        }
    }
}
