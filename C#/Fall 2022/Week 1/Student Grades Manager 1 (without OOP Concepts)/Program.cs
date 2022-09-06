using System;
using System.Collections.Generic;//importing the library that allows us to use list

namespace ListPrint
{
    class ListPrint
    {
        static void Main(string[] args)
        {
            List<string> strnamelst = new List<string> { };//creating the empty list
            List<int> intamelst = new List<int> { };//creating the empty list
            int intuserinput = 0;
            while (intuserinput != 3)
            {
                
                Console.WriteLine("Please select one of the following commands to issue:");
                Console.WriteLine("1. Enter Students (name, grade)\n2. Display student grade average\n3. Quit");
                intuserinput = int.Parse(Console.ReadLine());
                if (intuserinput == 1)
                {
                    Console.Clear();
                    Console.WriteLine("1");
                    Console.ReadKey();
                }
                else if (intuserinput == 2)
                {
                    Console.Clear();
                    Console.WriteLine("2");
                    Console.ReadKey();
                }
                else if (intuserinput == 3)
                {
                    Console.Clear();
                    Console.WriteLine("3");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Else");
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }
    }
}