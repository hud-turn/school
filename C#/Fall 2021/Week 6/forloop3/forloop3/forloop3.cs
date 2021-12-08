using System;

namespace forloop3
{
    class forloop3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there! This program is designed to go through a sequence of numbers using a mathematics problem.");//Tells the user the purpose of this program
            Console.WriteLine("The equation we are using to come up with these numbers is x = 10 x 3 ^(n-1)");//Tells the user how these numbers are created
            for (double doubiter = 1, doubexpon = 0, doubcalcI = 0, doubvalue = 0; doubiter < 101; doubiter++ )//setting out the parameters to enter the for loop. I also had to use a double since decimal and float did not have enoug data associated with their data types
            {
                //the mathematic equation we are trying to create with the process below is x = 10 x 3 ^(n-1) where n stands for ever iteration that this program goes through
                doubexpon = doubiter - 1;//creating the exponent for the calculator to process
                doubcalcI = Math.Pow(3, doubexpon);//appling the exponent to the common ratio
                doubvalue = 10 * doubcalcI;//multiplying the first term by the common ratio that had the exponent applied
                Console.WriteLine("When " + doubiter + " is the term. The equation comes out as " + doubvalue);//outputting the result                
            }
            Console.ReadKey();//prevents the program from closing automatically
        }
    }
}
