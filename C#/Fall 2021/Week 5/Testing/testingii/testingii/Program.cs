using System;

namespace testingii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            string strinput = Console.ReadLine();
            float fltinput = float.Parse(strinput);

            if ( fltinput >= 10)
            {
                Console.WriteLine("Big");
            }
            else
            {
                Console.WriteLine("Small");
            }
        }
    }
}
