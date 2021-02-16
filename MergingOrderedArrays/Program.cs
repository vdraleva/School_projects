using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergingOrderedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.Сливане на подредени масиви            
           int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] b = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] c= new int[40];
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int swapVar = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < b.Length - 1; i++)
            {
                for (int j = 0; j < b.Length - 1; j++)
                {
                    if (b[j] > b[j + 1])
                    {
                        int swapVar = b[j];
                        b[j] = b[j + 1];
                        b[j + 1] = swapVar;
                    }
                }
                //Console.Write(a[i] + " ");
                //Console.Write(b[i] + " ");
            }
          int i1= 0,j1 = 0,k = 0;
          while (i1<a.Length &&j1<b.Length)
            {
                if (a[i1] < b[j1])
                {
                    c[k]=a[i1];
                    k++;
                  i1++;
                }
                else
                {
                    c[k] = b[j1];
                   j1++;
                  k++;
                }
            }
          while (i1 < a.Length)
          {
              c[k] = a[i1];
              k++;
              i1++;
          }
          while (j1 < b.Length)
          {
              c[k] = b[j1];
              k++;
              j1++;
          }
          for (int i = 0; i < k; i++)
          {
              Console.Write(c[i]+" ");
          }


             List<int> array = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
              List<int> sortedArray = MakeSort(array);
              foreach (int item in sortedArray)
              {
                  Console.WriteLine(item);
              }

          }
          static List<int> MakeSort(List<int> array)
          {
              List<int> firstHalf = new List<int>();
              List<int> secondHalf = new List<int>();
              List<int> merge = new List<int>();
              if (array.Count > 1)
              {
                  foreach (int element in array)
                  {
                      if (firstHalf.Count < array.Count / 2)
                      {
                          firstHalf.Add(element);
                      }
                      else
                      {
                          secondHalf.Add(element);
                      }
                  }
                  List<int> firstSorted = MakeSort(firstHalf);
                  List<int> secondSorted = MakeSort(secondHalf);
                  merge = MergeLists(firstSorted, secondSorted);
              }
              else
              {
                  merge.Add(array[0]);
              }
              return merge;
          }
          static List<int> MergeLists(List<int> first, List<int> second)
          {
              List<int> combine = new List<int>();
              while ((first.Count > 0) && (second.Count > 0))
              {
                  if (first[0] < second[0])
                  {
                      combine.Add(first[0]);
                      first.RemoveAt(0);
                  }
                  else
                  {
                      combine.Add(second[0]);
                      second.RemoveAt(0);
                  }
              }
              foreach (int item in first)
              {
                  combine.Add(item);
              }
              foreach (int item in second)
              {
                  combine.Add(item);
              }
              return combine;
          
        }
    }
}
