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
                Console.Clear();//clears the terminal to make the window cleaner
                Console.WriteLine("Please select one of the following:\n1. About this developer\n2. Exit the program");//main menu tells the user how to use the program
                string struserinput = Console.ReadLine();//gets user input
                intuserinput = int.Parse(struserinput);//converts user input string to int
                if (intuserinput == 1)//looks to see if the user int is a 1
                {
                    Console.Clear();//clears the terminal
                    Console.WriteLine("Hello, you have selected about this developer.\nThe developer of this program is Hudson who is a senior CIS major at UNC.");//information
                    Console.ReadKey();//exits information window when the user hits a key
                }
                else if (intuserinput > 2 || intuserinput < 1) //looks to see if the user int is greater than one or two
                {
                    Console.Clear();//clears terminal
                    Console.WriteLine("Please enter 1 or 2");//tells user to enter 1 or 2
                    Console.ReadKey();//exits this menu when user hits key
                }
            }

        }

    }
}