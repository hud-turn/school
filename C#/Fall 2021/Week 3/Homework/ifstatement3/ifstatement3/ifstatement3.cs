using System;

namespace ifstatement3
{
    class ifstatement3
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a number:");//This tells the user the function of the program
            string strinput = Console.ReadLine();//this gets the user input
            decimal decinput = decimal.Parse(strinput);//this converts the users string input into decimal form
            if (decinput > 0)//if the input is larger than zero it returns the following line
            {
                Console.WriteLine("The number you put in is a positive number.");
                Console.ReadKey();//Once the line above is read into the terminal this line will prevent the program from closing
            }
            if (decinput < 0)//if the input is smaller than zero it returns the following line
            {
                Console.WriteLine("The number you put in is a negative number.");
                Console.ReadKey();//Once the line above is read into the terminal this line will prevent the program from closing
            }
            if (decinput == 0) //if the input equals zero it reutns the following line
            {
                Console.WriteLine("The number you put in is equal to zero.");
                Console.ReadKey();//Once the line above is read into the terminal this line will prevent the program from closing
            }
        }
    }
}