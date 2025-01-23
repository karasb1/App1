namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, n1 = 0, n2 = 1;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + " ");
            Console.Write(n2 + " ");
            while (true)
            {
                int s = n1 + n2;
                if (s < b)
                {
                    Console.Write(s + " ");
                }
                else
                {
                    break;
                }
                n1 = n2;
                n2 = s;
            }
        }   
    }
}
