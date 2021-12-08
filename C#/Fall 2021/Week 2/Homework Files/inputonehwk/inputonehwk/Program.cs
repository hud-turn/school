using System;

namespace inputonehwk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Writing out what the user should input so they know what to do
            Console.Write("Please input 5 numbers that you want to average. \n Your first number is:");

            //Recording the users input and also cleaning up the UI so it looks better
            //I would like a method that allows me to add the averages more like a 
            //list but that might not be possible since the terminal might just print off each output as its own seperate line
            string strone = Console.ReadLine();
            Console.Write("Your second number is:");
            string strtwo = Console.ReadLine();
            Console.Write("Your third number is:");
            string strthree = Console.ReadLine();
            Console.Write("Your fourth number is:");
            string strfour = Console.ReadLine();
            Console.Write("Your fifth number is:");
            string strfive = Console.ReadLine();

            //Converting the string inputs into decimal form so we can process the data
            decimal decone = decimal.Parse(strone);
            decimal dectwo = decimal.Parse(strtwo);
            decimal decthree = decimal.Parse(strthree);
            decimal decfour = decimal.Parse(strfour);
            decimal decfive = decimal.Parse(strfive);

            //Doing the math with the inputs so that we can get an average
            decimal sum = decone+dectwo+decthree+decfour+decfive;
            decimal average = sum/5;

            //Outputting the average for the user to see
            Console.WriteLine("The average for the 5 numbers you entered is:" + average);
            Console.ReadKey();

        }
    }
}
