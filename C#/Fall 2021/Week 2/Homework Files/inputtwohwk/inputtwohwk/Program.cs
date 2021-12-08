using System;

namespace inputtwohwk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beginning of the program, introducing what the function of this program is so that the user is aware of how it works
            Console.Write("Hi there!\nThis is a general purpose calculator that will add, subtract, divide, multiply, and raise first number you input by the power that you input for the second number.\nPlease input the first number:");
            string strfirstnumber = Console.ReadLine();//record inputs
            Console.Write("Please input the second number:");
            string strsecondnumber = Console.ReadLine();//record inputs

            //Converting string data to decimal data so it can be used
            decimal decfirstnumber = decimal.Parse(strfirstnumber);
            decimal decsecondnumber = decimal.Parse(strsecondnumber);

            //Converting the string variable to a double so that it can be used in the Math.Pow() function.
            double doublfirstnumber = double.Parse(strfirstnumber);
            double doublsecondnumber = double.Parse(strsecondnumber);

            //Processing the data
            decimal add = decfirstnumber + decsecondnumber;
            decimal subtract = decfirstnumber - decsecondnumber;
            decimal divide = decfirstnumber / decsecondnumber;
            decimal multip = decfirstnumber * decsecondnumber;
            double power = Math.Pow(doublfirstnumber,doublsecondnumber);

            //Printing it to the console and formatting the output so that it looks nice.
            Console.WriteLine("If you add " + decfirstnumber + " to " + decsecondnumber + " then you get " + add + ".");
            Console.WriteLine("If you subtract " + decfirstnumber + " from " + decsecondnumber + " then you get " + subtract + ".");
            Console.WriteLine("If you divide " + decfirstnumber + " by " + decsecondnumber + " then you get " + divide + ".");
            Console.WriteLine("If you multiply " + decfirstnumber + " by " + decsecondnumber + " then you get " + multip + ".");
            Console.WriteLine("If you raise " + decfirstnumber + " to the power of " + decsecondnumber + " then you get " + power + ".");

            //V so that the user has to press a key to exit the program
            Console.ReadKey();
        }
    }
}
