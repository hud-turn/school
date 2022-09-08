using System;
using System.Collections.Generic;//importing the library that allows us to use list

namespace ListPrint
{
    class ListPrint
    {
        static void Main(string[] args)
        {
            List<string> strnamelst = new List<string> { };//creating the empty list
            List<decimal> decgrdlst = new List<decimal> { };//creating the empty list
            int intuserinput = 0;
            
            while (intuserinput != 3)
            {
                
                Console.WriteLine("Please select one of the following commands to issue:");
                Console.Write("1. Enter Students (name, grade)\n2. Display student grade average\n3. Quit\nWhat would you like to do?: ");//gives the user
                intuserinput = int.Parse(Console.ReadLine());//getting user input
                if (intuserinput == 1)//if the user selects the enter students name and grade option
                {
                    Console.Clear();//clears terminal
                    Console.WriteLine("Please input the name of the student you want to add:");//tells the user how to use the program
                    strnamelst.Add(Console.ReadLine());//adding name to list
                    Console.Clear();//clear
                    Console.WriteLine("Please input the letter grade of the student you just added:");//telling user what to do
                    decgrdlst.Add(decimal.Parse(Console.ReadLine()));//converts a string to a decimal and then adds it to the decimal list
                    Console.Clear();//clears console
                    Console.WriteLine("Great! You entered the student's information.\nYou will be returned to the main menu in 3 seconds.");//telling user what to do
                    System.Threading.Thread.Sleep(3000);//tells the program to sleep for 3000 milliseconds
                }
                else if (intuserinput == 2)//if the user selects the display student grade average
                {
                    Console.Clear();//clears terminal
                    decimal decsuminput = 0;//resets the sum
                    foreach (decimal dec in decgrdlst)
                    {
                        decsuminput += dec;//recomputes the sum
                    }
                    Console.WriteLine("The average grade of the students in this class is: " + decsuminput/decgrdlst.Count() + "\nYou will be returned to the main menu in 3 seconds.");//outputs the student grade average
                    System.Threading.Thread.Sleep(3000);//tells the program to sleep for 3000 milliseconds
                }
                else if (intuserinput == 3)
                {
                    Console.Clear();//clears console and prevents the else from catching a 3
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hello!\n\nYou input an improper number.\nPlease try again and input a number between 1 - 3.\nYou will be returned to the main menu in 3 seconds.");
                    System.Threading.Thread.Sleep(3000);//tells the program to sleep for 3000 milliseconds
                }
                Console.Clear();//clearing terminal
            }
        }
    }
}