using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveTheNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача: Изтриване на отрицателни елементи
            
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < 0)
                {
                    nums.Remove(nums[i]);
                }
            }
            nums.Reverse();
            Console.Write(string.Join(" ", nums));
            Console.WriteLine();
            
        }
    }
}
