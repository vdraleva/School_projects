using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static int Fact(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Fact(n - 1);
            }
        }
        static int SumArr(int[] a, int start)
        {
            if (start == a.Length)
            {
                return 0;
            }
            else
            {
                return a[start] + SumArr(a, start + 1);
            }
        }
        static int ProductArr(int[] a, int start)//1,2,3,4=1*2*3*4
        {
            if (start == a.Length)
            {
                return 1;
            }
            else
            {
                return a[start] * SumArr(a, start + 1);
            }
        }
        static int DigitalRoot(int n)
        {
            if (n<10)
            {
                return n;
            }
            return DigitalRoot(SumD(n));
        
        }
        static int SumD(int n)//523=5+2+3
        {
            if (n < 10)
            {
                return n;
            }
            return n % 10 + SumD(n / 10);
        }
        static void HanoiTower(int disks, char src, char mid, char dest)
        {
            if (disks==1)
            {
                Console.WriteLine($"{src}->{dest}");
                return;
            }
            HanoiTower(disks-1,src,dest,mid);
            HanoiTower(1,src,mid,dest);
            HanoiTower(disks - 1, mid, src, dest);
        }
        static int GCD(int a, int b)//NOD
        {
            if (b==0)
            {
                return a;
            }
            return GCD(b, a % b);
        }
        static void PrintNumbers(int n)
        {
            if (n==0)
            {
                return;
            }
            else
            {
                PrintNumbers(n-1); //if this line is above the CW, the numbers are straight from 1-10
                Console.WriteLine(n);
                //PrintNumbers(n - 1); //if this line is below the CW, the numbers get reversed 10-1
            }
        }
        static int BinarySearch(int[] arr, int left, int right, int x)
        {
            if (right >= left)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == x)
                {
                    return mid;
                }
                else if (x < arr[mid])
                {
                    Console.WriteLine("DOWN");
                    return BinarySearch(arr, left, mid - 1, x);
                }
                else
                {
                    Console.WriteLine("UP");
                    return BinarySearch(arr, mid + 1, right, x);
                }
            }
            return -1;
        }

        static int BinarySearch(int[] arr, int x)
        {
            return BinarySearch(arr, 0, arr.Length, x);
        }

        static int[] SortedMerge(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            int ia = 0, ib = 0, ic = 0;
            while (ic < c.Length)
            {
                if (ia < a.Length && ib < b.Length)
                {
                    if (a[ia] < b[ib])
                    {
                        c[ic] = a[ia];
                        ia++;
                    }
                    else
                    {
                        c[ic] = b[ib];
                        ib++;
                    }
                }
                else if (ia < a.Length)
                {
                    c[ic] = a[ia];
                    ia++;
                }
                else
                {
                    c[ic] = b[ib];
                    ib++;
                }
                ic++;
            }
            return c;
        }

        static int[] MergeSort(int[] arr)
        {
            int[] left, right;

            int[] result = new int[arr.Length];

            if (arr.Length <= 1)
            {
                return arr;
            }
            int mid = arr.Length / 2;

            left = new int[mid];

            if (arr.Length % 2 == 0)
            {
                right = new int[mid];
            }
            else
            {
                right = new int[mid + 1];
            }

            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }

            for (int i = mid, j = 0; i < arr.Length; i++, j++)
            {
                right[j] = arr[i];
            }

            left = MergeSort(left);
            right = MergeSort(right);

            result = SortedMerge(left, right);

            return result;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Fact(6));
            //  PrintNumbers(10);
            /*int[] a = { 1, 2, 3 };
            Console.WriteLine(SumArr(a,0));*/
           // HanoiTower(3,'A','B','C');
            int[] a = { 1, 2434, 54, -34, 43, 544, 1054, 204, 78 };
            int[] result = MergeSort(a);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("{0} ", result[i]);
            }
        }
    }
}
