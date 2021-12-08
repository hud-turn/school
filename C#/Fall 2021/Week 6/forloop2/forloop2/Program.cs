using System;

namespace forloop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that asks the user to enter 10 numbers. At the end of the loop, make sure to print out out:

            //smallest number entered
            //largest number entered
            //average of all numbers entered
            //count of how many numbers divisible by 13
            Console.WriteLine("Hello! \nThis program will find the smallest number input, the largest number input, the average, and if it is divisible by 13.");//telling the purpose of the program to the user so they know what's going on
            for (decimal decinput, decsml = decimal.MaxValue, declrg = decimal.MinValue, decsum = 0, decaverage = 0, decdiv = 0, decdivcount = 0, deciter = 0; deciter != 10; deciter++)//declaring variables and conditions for the for loop
            {
                Console.Write("Please input a number:");//tels user to input number
                decinput = decimal.Parse(Console.ReadLine());//converts user input to decle format
                if (decinput < decsml)//if the input is smaller than the smallest number on file then it records the input as the smallest number
                {
                    decsml = decinput;
                }
                if (decinput > declrg)//if the input is larger than the largest number on file then it records the input as the smallest number
                {
                    declrg = decinput;
                }
                decsum = decsum + decinput; //adds the input to the sum so we can calculate average later
                decdiv = decinput % 13;//divides input by 13 and looks for remainder
                if (decdiv == 0)//if no remainder found then the number divides neatly
                {
                    decdivcount++;//adds one to the decimal division count so we can take that ouput later and display it
                }
                if (deciter == 9)//this will be executed at the last cycle of the loop
                {
                    decaverage = decsum / 10;//creating the average of the inputs
                    Console.WriteLine("The smallest number entered was: " + decsml +"\nThe largest number entered was: " + declrg + "\nThe average across all entries was: " + decaverage + "\nYou entered a number divisible by 13 " + decdivcount + " times.");//outputting the results of the program
                    Console.ReadKey();//preventing the program from automagically closing
                }
            }
        }
    }
}
