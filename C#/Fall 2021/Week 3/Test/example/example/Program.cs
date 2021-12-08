using System;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string data = Console.ReadLine();

            decimal x = decimal.Parse(data);

            Console.WriteLine("Enter another number:");
            data = Console.ReadLine();

            decimal y = decimal.Parse(data);
            decimal z = x / y;

            Console.WriteLine(x + "/" + y + "=" + z);
            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
