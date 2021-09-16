using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише нерекурсивна (рекурсивна) функция, 
            //която проверява дали елемент принадлежи на списък(стек, опашка).
            List<int> listOne = new List<int>();
            listOne.Add(5);
            listOne.Add(3);
            listOne.Add(4);
            listOne.Add(52);
            listOne.Add(2);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < listOne.Count; i++)
            {
                if (listOne.Contains(n))
                {
                    Console.WriteLine("There is");
                    return;
                }
            }
            Console.WriteLine("There isn't");
        }
    }
}
