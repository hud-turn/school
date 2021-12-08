using System;

namespace ifstatement1
{
    class ifstatement1
    {
        static void Main(string[] args)
        {
            Console.Write("Hello! Please input a number that you would like to divide: ");//Allows for the user to know what they are inputting into the system.
            string strnumx = Console.ReadLine();//gets input from user for data variable x
            decimal decnumx = decimal.Parse(strnumx);//converts str to dec data type.
            
            Console.Write("Please input a number that you would like to divide " + strnumx + " by:");//lets the user know what they are dividing by.
            string strnumy = Console.ReadLine();//gets input from userfor data variable y.
            decimal decnumy = decimal.Parse(strnumy);//converts str to dec data type.

            if (decnumy == 0) //conditional programming where if the user tries to divide by zero they will get an error code out.
            {
                Console.WriteLine("You are unable to divide by 0, please use a non-zero number to divide by.");
            }
            else //this will return the result and let the user know what the result of the division problem.
            {
                decimal result = decnumx / decnumy;//this is where we divide x/y and produce the result
                Console.WriteLine("The result of " + decnumx + "/" + decnumy + " = " + result + ".");//printing out the x/y equation
            }
            Console.ReadKey();//setting the console into standby so that the user doesn't exit out of the program automatically
        }
    }
}
