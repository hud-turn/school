using System;

namespace array4
{
    class array4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Purpose of this program is to change the order of the numbers.");//telling the user the purpose of the program

            int[] intarray = new int[10];//creating an array that we will input to
            int[] intarraymod = new int[10];//creating the array that we will output later

            for (int i = 0; i < 10; i++)//moving the user input into the array
            {
                Console.Write("Please input a number: ");//telling the user to input the data
                intarray[i] = int.Parse(Console.ReadLine());//getting the user input
            }

            //Array.Sort(intarray);//sorting the array so that it is in ascending order. I left this command as a comment so that it is a feature that could be easily enabled or disabled per user request

            for (int i = 0, j = 5; i < 5; i++, j++)//adds the first half of the data from the first to the second string
            {
                intarraymod[j] = intarray[i];//importing the array into the other array
            }

            for (int i = 5, j = 0; i < 10; i++, j++)//adds the second half of the data from the first to the second string
            {
                intarraymod[j] = intarray[i];//importing the array into the other array
            }

            Console.Write("These are the numbers you input in a slightly different order: {");
            for (int i = 0; i != 10; i++)//outputting the program output
            {
                Console.Write(intarraymod[i]);//outputting the program output
                if (i != 9)
                {
                    Console.Write(",");//helps with formatting the program output to match the program parameters
                }
                else
                {
                    Console.Write("}");//helps with formatting the program output to match the program parameters
                }
            }
            Console.ReadKey();//prevents program from exiting

            //Program Parameters
            //User inputs the following list of numbers {1,2,3,4,5, 6,7,8,9,10}
            //Your program needs to print out the array in the following order { 6,7,8,9,10,1,2,3,4,5}
        }
    }
}
