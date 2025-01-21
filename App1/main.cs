namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, result = 0;
            number = Convert.ToInt32(Console.ReadLine());
            while(number > 0)
            {
                result = result * 10 + number % 10;
                number = number / 10;
            }
            Console.WriteLine(result);  
        }   
    }
}
