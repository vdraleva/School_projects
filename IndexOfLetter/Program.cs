using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Индекс на буква

            string a = Console.ReadLine();
            foreach (var item in a.ToString())
                Console.WriteLine($"{item} -> {(int)item - 97}");
        }
    }
}
