using System;

namespace countingupfromx
{
    class countingupfromx
    {
        static void Main(string[] args)
        {
            //This line helps the user figure out what the purpose of the program is.
            Console.Write("Please input the number you where you want to display the next 8 numbers: ");

            //This line is the input that will define what number is input into the program.
            string strnumb = Console.ReadLine();

            //This line will convert the string strnumb into a decimal data type decnumb.
            decimal decnumb = decimal.Parse(strnumb);

            //decnumb is equal to the number the number they put in at this moment when the code is being executed.
            Console.Write("The output of the next 8 numbers following " + decnumb + " are: ");
            decnumb++; //This line adds +1 to the variable decnumb.
            Console.Write(decnumb + ", ");//This line prints the variable decnumb.
            decnumb++;
            Console.Write(decnumb + ", ");//decnum has been incremented by 2 so far.
            decnumb++;
            Console.Write(decnumb + ", ");//decnum has been incremented by 3 so far.
            decnumb++;
            Console.Write(decnumb + ", ");//decnum has been incremented by 4 so far.
            decnumb++;
            Console.Write(decnumb + ", ");//decnum has been incremented by 5 so far.
            decnumb++;
            Console.Write(decnumb + ", ");//decnum has been incremented by 6 so far.
            decnumb++;
            Console.Write(decnumb + ", and ");//decnum has been incremented by 7 so far.
            decnumb++;
            Console.Write(decnumb + ".");//decnum has been incremented by 8 so far.
            Console.ReadKey();//This line will prevent the window from closing automatically.
        }
    }
}
