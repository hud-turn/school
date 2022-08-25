using System;
namespace ConsoleMenu 
{
    class Program
    {
        static void Main()
        {
            int intuserinput = 0;
            while (intuserinput != 2)
            {
                string struserinput = Console.ReadLine();
                intuserinput = int.Parse(struserinput);
                Console.Clear();
                Console.WriteLine("Please select one of the following:\n1. About this developer\n2. Exit the program");
                if (intuserinput == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Hello, you have selected about this developer.\nThe developer of this program is Hudson who is a senior CIS major at UNC.");
                    Console.ReadKey();
                }
                else if (intuserinput > 2 || intuserinput < 1) 
                {
                    Console.Clear();
                    Console.WriteLine("Please enter 1 or 2");
                    Console.ReadKey();
                }
            }

        }

    }
}