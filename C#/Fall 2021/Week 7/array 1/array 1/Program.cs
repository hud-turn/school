using System;

namespace array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intvalue = new int[10];//creating the array
            int i = 0, h = 0;//the variables that will be called in the program

            Console.WriteLine("The purpose of this program is to ast the user to enter 10 numbers that range from 10-100.\nWe are unable to accept any number below 10 or above 100.\n");//tells the user the function of the program

            while (i < 10)
            {
                if (i == 0)
                {
                    Console.Write("Please input a number, this is your 1st try: ");//telling the user what try they are on
                }
                if (i == 1)
                {
                    Console.Write("Please input a number, this is your 2nd try: ");//telling the user what try they are on
                }
                if (i == 2)
                {
                    Console.Write("Please input a number, this is your 3rd try: ");//telling the user what try they are on
                }
                if (i >= 3)
                {
                    h = i + 1;
                    Console.Write("Please input a number, this is your " + h + "th try: ");//telling the user what try they are on
                }
                int intusrinpt = int.Parse(Console.ReadLine());//takes the user input and converts it to int form
                if (intusrinpt >= 10 && intusrinpt <= 100)//looks to see if the user input is within the valid range
                {
                    intvalue[i] = intusrinpt;//puts the user input into the address space in the array
                    //Console.WriteLine(intvalue[i]);
                    i++;//moves the iteration value up by one in order to move onto the next array space
                }
                else
                {
                    Console.WriteLine("Please input a number between 10-100. Please try again!");//the error out code if the previous statement was false
                }
            }
            Console.WriteLine("Here are the numbers you entered in ascending order: ");//format so the user can see what these numbers mean
            Array.Sort(intvalue);//formatting the numbers in the array
            foreach (int j in intvalue) Console.WriteLine(j);//writing out the numbers in the array
            Console.ReadKey();//preventing the program from closing
            //I used these sources to help me figure out how to do my code in a way that would allow it to function
            //https://www.csharp-examples.net/sort-array/ and https://www.w3schools.com/cs/cs_arrays.php
        }
    }
}
