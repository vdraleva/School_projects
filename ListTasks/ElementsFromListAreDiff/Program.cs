using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementsFromListAreDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише нерекурсивна (рекурсивна) функция,
            //която проверява дали елементите на стек от числа са различни.
            List<int> listOne = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < listOne.Count-1; i++)
            {
                for (int j = i+1; j < listOne.Count; j++)
                {
                    if (listOne[i]==listOne[j])
                    {
                        Console.WriteLine("there is a diff num");
                        Console.WriteLine(listOne[i]);
                        return;
                    }
                }
            }
            Console.WriteLine("there isn't diff num");
            Console.WriteLine(string.Join(" ",listOne));
        }
    }
}
