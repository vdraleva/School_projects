using System;

namespace Array_Short_Quick_Bubble
{
    class Program
    {
        static void Main(string[] args)
        {          
            int n = int.Parse(Console.ReadLine()); 
            int[] myArray = new int[n];
            for (int i = 0; i < n; i++)
            {               
                myArray[i] = int.Parse(Console.ReadLine());
            }
            int min, imin;
            for (int i = 0; i < n-1; i++)
            {
                min = myArray[i];
                imin = i;
                for (int j = i+1; j < n; j++)
                {
                    if (min>myArray[j])
                    {
                        min = myArray[j];
                        imin = j;
                    }
                    myArray[imin] = myArray[i];
                    myArray[i] = min;
                }

            }
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
