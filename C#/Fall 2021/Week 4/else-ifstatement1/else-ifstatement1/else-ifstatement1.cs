using System;

namespace else_ifstatement1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello! Please input the number that you want to check if it is divisible by 2, 3, 4, 5, 6, 7 or 8: ");//tells user function of program
            string strnuminput = Console.ReadLine();//getting user input
            decimal decnuminput = decimal.Parse(strnuminput);//converting string input into decimal

            decimal decdivtwo = decnuminput % 2;//this line divides the input for us
            decimal decdivthree = decnuminput % 3;//this line divides the input for us
            decimal decdivfour = decnuminput % 4;//this line divides the input for us
            decimal decdivfive = decnuminput % 5;//this line divides the input for us
            decimal decdivsix = decnuminput % 6;//this line divides the input for us
            decimal decdivseven = decnuminput % 7;//this line divides the input for us
            decimal decdiveight = decnuminput % 8;//this line divides the input for us

            if (decdivtwo == 0)//this line looks to see if the number is divisible.
            {
                Console.Write("The number " + decnuminput + " is divisible by 2.");
            }
            else if (decdivthree == 0)//this line looks to see if the number is divisible.
            {
                Console.Write("The number " + decnuminput + " is divisible by 3.");
            }
            else if (decdivfour == 0)//this line looks to see if the number is divisible.
            {
                Console.Write("The number " + decnuminput + " is divisible by 4.");
            }
            else if (decdivfive == 0)//this line looks to see if the number is divisible.
            {
                Console.Write("The number " + decnuminput + " is divisible by 5.");
            }
            else if (decdivsix == 0)//this line looks to see if the number is divisible.
            {
                Console.Write("The number " + decnuminput + " is divisible by 6.");
            }
            else if (decdivseven == 0)//this line looks to see if the number is divisible.
            {
                Console.Write("The number " + decnuminput + " is divisible by 7.");
            }
            else if (decdiveight == 0)//this line looks to see if the number is divisible.
            {
                Console.Write("The number " + decnuminput + " is divisible by 8.");
            }
            else //this number looks and if it is not divisible by any of the numbers above then it outputs this
            {
                Console.Write("The number " + decnuminput + " is not divisible by any of these numbers.");
            }
        }
    }
}
