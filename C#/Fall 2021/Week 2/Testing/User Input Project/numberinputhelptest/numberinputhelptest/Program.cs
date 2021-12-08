using System;

namespace numberinputhelptest
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString;
            Console.Write("Enter a string - ");
            testString = Console.ReadLine();
            Console.WriteLine("You entered '{0}'", testString);
        }
    }
}
