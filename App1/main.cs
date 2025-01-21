using System.Diagnostics.CodeAnalysis;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for(int i = 0; i < 5; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int multiplication = 1;
            for (int i = 0; i < 5; i++)
            {
                multiplication *= array[i];
            }
            Console.WriteLine($"Sum = {array.Sum()}");
            Console.WriteLine($"Max = {array.Max()}");
            Console.WriteLine($"Min = {array.Min()}");
            Console.WriteLine($"Multiplication = {multiplication}");
        }   
    }
}
