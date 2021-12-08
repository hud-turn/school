using System;

namespace extracreditII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This is an Italian translator,");//This lets the user know what the function of the program is
            int intincorrect = 0;//creating an incorrect iterator
            string strusrinptup = null;//initializing the variable
            while (strusrinptup != "-1")//if the user input string does not equal -1 then repeat this block of code 
            {
                Console.Write(" Please input the word you want to translate: ");//This lets the user know what the function of the program is
                string strusrinpt = Console.ReadLine();//this gets the users input
                strusrinptup = strusrinpt.ToUpper();
                if (strusrinptup == "ALLOW")//checks the input string to see if it matches the word requirement
                {
                    Console.WriteLine("This translates to permettere in Italian."); 
                }
                else if (strusrinptup == "ACCEPT")//checks the input string to see if it matches the word requirement
                {
                    Console.WriteLine("This translates to accettare in Italian.");
                }
                else if (strusrinptup == "BELIEVE")//checks the input string to see if it matches the word requirement
                {
                    Console.WriteLine("This translates to credere in Italian.");
                }
                else if (strusrinptup == "BUY")//checks the input string to see if it matches the word requirement
                {
                    Console.WriteLine("This translates to comprare in Italian.");
                }
                else if (strusrinptup == "DANCE")//checks the input string to see if it matches the word requirement
                {
                    Console.WriteLine("This translates to ballare in Italian.");
                }
                else if (strusrinptup == "DRIVE")//checks the input string to see if it matches the word requirement
                {
                    Console.WriteLine("This translates to guidare in Italian.");
                }
                else if (strusrinptup == "EAT")//checks the input string to see if it matches the word requirement
                {
                    Console.WriteLine("This translates to mangiare in Italian.");
                }
                else if (strusrinptup == "EXPLAIN")//checks the input string to see if it matches the word requirement
                {
                    Console.WriteLine("This translates to speigare in Italian.");
                }
                else if (strusrinptup == "HAVE")//checks the input string to see if it matches the word requirement
                {
                    Console.WriteLine("This translates to avere in Italian.");
                }
                else if (strusrinptup != "-1")//checks the input string to see if it matches the word requirement to exit the program
                {
                    Console.WriteLine("The word you put in could not be translated, please try again.");
                    intincorrect++;//adds the number of times that the user input a word that could not be translated
                }
            }
            Console.WriteLine("You entered a word that could not be translated " + intincorrect + " times");//gives the user the results of the number of times that they entered a word that could not be translated
            Console.ReadKey();
        }
    }
}
