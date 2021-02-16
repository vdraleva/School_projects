using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача: Премахни числото
             
             List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
             int number = nums[nums.Count-1];
             while (nums.Contains(number))
             {
                 nums.Remove(number);
             }
             Console.Write(string.Join(" ",nums));
             Console.WriteLine();
             
        }
    }
}
