using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackContaintNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackOne = new Stack<int>();
            stackOne.Push(5);
            stackOne.Push(3);
            stackOne.Push(4);
            stackOne.Push(52);
            stackOne.Push(2);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < stackOne.Count; i++)
            {
                
                    if (stackOne[i] == stackOne[i+1])
                    {
                    Console.WriteLine("There is");
                    return;
                    
                }
                
            }
            Console.WriteLine("There isn't");
        }
    }
}
