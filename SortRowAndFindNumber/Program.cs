using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortRowAndFindNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //сортиран ред - намиране на числото 
            int[] a = new int[20];
            int n = int.Parse(Console.ReadLine());
            for (int p = 0; p < n; p++)
            {
                a[p] = int.Parse(Console.ReadLine());
            }
            int x = int.Parse(Console.ReadLine());
            int i = 0, j = n - 1, sr = (i + j) / 2;
            while (i <= j && a[sr] != x)
            {
                if (a[sr] == x) j = sr - 1;
                else i = sr + 1;
                sr = (i + j) / 2;
            }
            if (a[sr] == x) Console.WriteLine("Yes");
            else Console.WriteLine("No"); 
        }
    }
}
