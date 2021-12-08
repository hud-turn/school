using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal total = 2 + 4 + 3 + 11.5m + 10;//creating the sum to input into the equation
            decimal average = total / 4;//dividing the sum by 10 to get the mean
            Console.Write(average);//printing out the averag to display to the terminal
            Console.ReadKey();//this prevents the console from closing
        }
    }
}
