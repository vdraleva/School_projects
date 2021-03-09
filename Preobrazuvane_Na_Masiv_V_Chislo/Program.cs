using System;
using System.Linq;

namespace Preobrazuvane_Na_Masiv_V_Chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();          

            for (int i = 0; i < myArr.Length - 1; i++)
            {
                int[] condensed = new int[myArr.Length - 1];

                for (int j = 0; j < myArr.Length - 1; j++) 
                {
                    condensed[j] = myArr[j] + myArr[j + 1];
                }

                myArr = condensed;
            }

            foreach (int item in myArr)
            {
                Console.WriteLine(item);               
            }
        }
    }
}
