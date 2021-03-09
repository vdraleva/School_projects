using System;
using System.Linq;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] b = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] c = new int[a.Length + b.Length];
            int i = 0, j = 0, k = -1;
            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    c[++k] = a[i++];
                }
                else
                {
                    c[++k] = b[j++];
                }
            }
            while (i < a.Length)
            {
                c[++k] = a[i++];
            }
            while (j < b.Length)
            {
                c[++k] = b[j++];
            }
            foreach (var item in c)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
