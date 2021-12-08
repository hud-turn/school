using System;

namespace whileloop1
{
    class whileloop1
    {
        static void Main(string[] args)
        {
            double doubinput = 0;//declaring the variable double input so that the program enters a while loop
            double doubiteration = 0;//this variable will store how many iteration or numbers we have input into the equation. We will use this number later to 
            double doubsumone = 0;//this is the beginning sum that we will divide in order to find the average
            Console.Write("Hello!\nThis a grade average calculator.");
            while (doubinput != -1)//if doubinput is not equal to 1 it will not launch the program
            {
                doubiteration++;//advances doubiteration by one so we know what we should be dividing by
                Console.Write("Please input a grade: ");//Gives user output so they know what they are doing. This line was moved down here so it would repeat and actully look ok.
                string strinput = Console.ReadLine();//getting the users input
                doubinput = double.Parse(strinput);//converting the string input to double. We don't have to declare the data type since it is already an established variable
                doubsumone = doubsumone + doubinput;//Adding the input to the sum which we can look at later (this was the hard part for me since I was trying to figure out how to sum the vars and it had been a short bit since I had done that last).
            }
            if (doubinput == -1)//if the number is guessed correctly then it will execute the code below. 
            {
                double average = doubsumone / doubiteration;//Takes the sum and divides it by the iteration in order to figure out the average
                Console.WriteLine("All together you got a sum of " + doubsumone +" points.\nThe average grade that you got was " + average + " points.");//I included the sum in this one so that it would make it easier to debug/fix
            }

        }
    }
}
