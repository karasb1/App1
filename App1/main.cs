namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter line length :");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sign :");
            string sign = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter 1 - Horizontal; 2 - Vertical");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(sign);
                }
            }
            else if (choice == 2)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(sign);
                }
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }   
    }
}
