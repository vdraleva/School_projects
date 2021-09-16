using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Stack<int> digits = new Stack<int>();
            while (num!=0)
            {
                digits.Push(num%10);
                num /= 10;
            }
            Console.WriteLine(string.Join("+",digits)+"="+digits.Sum());
        }
    }
}
