using Quiz;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Security.Principal;

namespace Quiz
{
    class Program
    {
        static void Main()
        {
            int userinput = 0, intinput = 0;
            string wordinput = null;
            bool boolinput = false;
            Practice practiceList = new Practice();
            while (userinput != 3)
            {
                Console.WriteLine("Please select a task to do out of the three options listed here.\n1) Practice\n2) Analytics\n3) Quit");
                userinput = int.Parse(Console.ReadLine());
                Console.Clear();
                if (userinput == 1)
                {
                    Console.WriteLine("Please input a word:");
                    wordinput = Console.ReadLine();
                    Console.WriteLine("How many vowels are there in the word?:");
                    intinput = int.Parse(Console.ReadLine());
                    Console.WriteLine("Are there repeating letters in the word?:");
                    boolinput = bool.Parse(Console.ReadLine());
                    Word wordlistinput = new Word (wordinput, intinput, boolinput);
                    practiceList.Add(wordlistinput);
                }
                else if (userinput == 2)
                {
                    
                }
                else if (userinput != 1 && userinput != 2 && userinput != 3)
                {
                    Console.Clear();
                    Console.WriteLine("Please input a valid number that is between 1 and 3");
                    Console.ReadKey();
                }
            }
        }
    }
}