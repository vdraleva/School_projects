using System;
using System.Linq;

namespace NaiChestoSreshtano
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max = 0;
            int repNum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                int currentNum = 0;

                for (int j = i; j < myArray.Length; j++)
                {
                    if (myArray[i] == myArray[j])
                    {
                        currentNum++;
                    }
                }

                if (currentNum > max)
                {
                    repNum = myArray[i];
                    max = currentNum;
                }
            }

            Console.WriteLine(repNum);
        }
    }
}
