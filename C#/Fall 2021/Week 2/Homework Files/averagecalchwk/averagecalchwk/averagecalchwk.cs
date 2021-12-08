using System;

namespace averagecalchwk
{
    class averagecalchwk
    {
        static void Main(string[] args)
        {
            decimal total = 20 + 3 + 83.2m + 35.9m + 155.5m + 42 + 64 + 1964 + 1654 + 1;//creating the sum to input into the equation to get the average/mean
            decimal average = total / 10;//dividing the sum by 10 to get the mean
            Console.WriteLine(average);//printing out the average to the display/terminal
        }
    }
}
