using System;

namespace testproj
{
    class Program
    {
        static void Main(string[] args)
        {
            for (decimal decsmlnum = decimal.MaxValue, declrgnum = decimal.MinValue, decsum = 1, decinput = 0, deciter = 0, decdiv = 0, decdiviter = 0; decinput != -1; deciter++)//declaring vars
            {
                if (deciter == 0)//inital first message
                {
                    Console.WriteLine("Hello there, this program will calculate the smallest, largest, the average, and if your number is divisible by 7.");
                }
                Console.Write("Please input a number: ");//telling the user to input a var
                decinput = decimal.Parse(Console.ReadLine());//parsing user inputs
                if (decinput > declrgnum && decinput != -1)//comparing variable statements to see if input is larger than the largest number on file so far
                {
                    declrgnum = decinput;
                }
                if (decinput < decsmlnum && decinput != -1)//comparing varible statements to see if input is smaller then the smallest number on file
                {
                    decsmlnum = decinput;
                }
                decsum = decsum + decinput;//calculating sum to be divided later by deciter
                decdiv = decinput % 7;//checking to see if the input is divisible by 7
                if (decdiv == 0)//if this number is divisible by 7 then it will add 1 to the divide iteration recorder
                {
                    decdiviter++;
                }
                if (decinput == -1)//if the input = -1 then it will exit the program but execute this code before doing so
                {
                    decimal decavg = decsum / deciter;//generating the sum so that we can output it in the following line
                    Console.WriteLine("The smallest number you entered was " + decsmlnum + "\nThe largest number you entered was " + decsmlnum + "\nThe average of the numbers you entered was " + decavg + "\nThe number of numbers that you entered that was divisible by 7 was " + decdiviter + ".");//outputting the results of the program before the program exits
                }
            }
        }
    }
}