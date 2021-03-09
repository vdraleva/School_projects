using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int x = int.Parse(Console.ReadLine());
            int left = 0;
            int right = myArr.Length - 1;
            int middle = (left + right) / 2;
            while (left <= right && myArr[middle] != x)
            {
                if (myArr[middle] < x)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
                middle = (left + right) / 2;
            }
            if (myArr[middle] == x)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
