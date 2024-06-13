using System.Threading.Channels;

namespace Zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 30 numbers");
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            int min = nums.Min();
            int max = nums.Max();
            int sum = 0;
            int zeroCount = 0;

            for (int i = 0; i < 30; i++)
            {
                
                if (nums[i] > 0)
                {
                    sum += nums[i];
                }
                if (nums[i] == 0)
                {
                    zeroCount++;
                }
            }
            Console.WriteLine($"Sum is:{sum}");
            Console.WriteLine($"the lowest element:{min}");
            Console.WriteLine($"The bigest element:{max}");
            Console.WriteLine($"The count of the o numbers is:{zeroCount}");
        }   
    }
}
