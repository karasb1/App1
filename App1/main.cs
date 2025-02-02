namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempurarure = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Convert from Celsius to Fahrenheit: " + (tempurarure*(9/5) + 32));
        }   
    }
}
