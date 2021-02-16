using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {   //Най-често срещано число    

            int n = 0;
            int[] num = new int[100];
            var line = Console.ReadLine();
            var splitted = line.Split(' ');
            foreach (var item in splitted)
                num[n++] = int.Parse(item);

            int[] counter = new int[100000];
            for (int i = 0; i < n; i++)
            {
                counter[num[i]]++;
            }
            int max = -1000, maxi = 0;
            for (int j = 0; j < 100000; j++)
            {
                if (counter[j] > max)
                {
                    max = counter[j];
                    maxi = j;
                }
            }
            Console.WriteLine($"Числото {maxi} е най-често срещаното (среща се {counter[maxi]} пъти)");
        }
    }
}
