using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = {50,20,10,5,2,1 };
            int sum = int.Parse(Console.ReadLine());
            int i = 0; 
            if (sum<=0)
            {
                Console.WriteLine("The number must be higher than 0");
            }
            while (sum!=0)
            {
                while (sum-coins[i]>=0)
                {
                    sum-=coins[i];
                    Console.Write(coins[i]+", ");
                }
                i++;
            }
           
        }
    }
}
