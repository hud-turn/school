using System;

namespace whileloop3
{
    class Program
    {
        static void Main(string[] args)
        {
            double doubleinput = double.MaxValue;//declaring the variable as a double and using the smallest double value allowable
            double doublesmallestnum = double.MaxValue;//declaring the variable as a double and using the smallest double value allowable
            Console.Write("Hello!\nThis program is a highest number detector.\n");
            while (doubleinput != -1)//if doubleinput is not equal to 1 it will not launch the program
            {
                Console.Write("Please input a number: ");//Gives user output so they know what they are doing. This line was moved down here so it would repeat and actully look ok.
                string stroneinput = Console.ReadLine();//getting the users input
                doubleinput = double.Parse(stroneinput);//converting the string input to double. We don't have to declare the data type since it is already an established variable
                if (doubleinput <= doublesmallestnum && doubleinput != -1)
                {
                    doublesmallestnum = doubleinput;
                    Console.WriteLine("The smallest number is " + doublesmallestnum + ".");

                }
                //else //these lines are here for testing purposes
                //{
                //Console.WriteLine("The smallest number was " + doublesmallestnum + "."); //These lines are here for testing purposes
                //}
            }
            if (doubleinput == -1)//if the number is guessed correctly then it will execute the code below. 
            {
                Console.WriteLine("The smallest number was " + doublesmallestnum + ".");//I included the sum in this one so that it would make it easier to debug/fix
            }
        }
    }
}
