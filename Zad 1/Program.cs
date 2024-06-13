namespace Zad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input how many nunbers you want:");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            
           Array.Reverse(array);

            
            Console.WriteLine(string.Join(" ", array));
        }
    }
}

