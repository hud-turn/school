using System;

namespace if_statement2
{
    class ifstatement2
    {
        static void Main(string[] args)
        {
            //Generate random number from the computer within the range of 1 and 10 using the random class
            Random rnd = new Random();
            int intrandomguess = rnd.Next(1, 10);

            //Accept user input
            Console.Write(intrandomguess + "\nGuess a number between 1 and 10: ");
            string strinputone = Console.ReadLine();//input for first try
            int intinputone = int.Parse(strinputone);//data conversion for first try

            if(intinputone == intrandomguess)//first guess was correct
            {
                Console.WriteLine("Congratulations! Your guess was correct!");
            }

            else if (10 < intinputone || intinputone < 1) //if first guess was not within range
            {
                Console.Write("You can't submit that number! Please use a number between 1 and 10: ");
                string strinputtwo = Console.ReadLine();//input for the second try
                int intinputtwo = int.Parse(strinputtwo);//data conversion for second try
                if (intinputtwo == intrandomguess) //second guess was correct
                {
                    Console.WriteLine("Congratulations! Your guess was correct!");
                }
                else if (10 < intinputtwo || intinputtwo < 1)//if second guess was out of range
                {
                    Console.Write("You can't submit that number! Please use a number between 1 and 10");
                    string strinputthree = Console.ReadLine();//input for third try
                    int intinputthree = int.Parse(strinputthree);//data conversion for third try
                    if (intinputthree == intrandomguess)//third guess is correct
                    {
                        Console.WriteLine("Congratulations! Your guess was correct!");
                    }
                    else if (10 < intinputthree || intinputthree < 1)//third try was out of range
                    {
                        Console.WriteLine("You can't submit that number and you are out of tries, please try again later!");
                    }
                    else//third try was incorrect
                    {
                        Console.WriteLine("That number was not correct and you are out of tries, please try again later!");
                    }
                }
                else//second input was not correct
                {
                    Console.Write("Your guess was incorrect! Please try again: ");
                    string strinputthree = Console.ReadLine();//third try input
                    int intinputthree = int.Parse(strinputthree);//third try input data conversion
                    if (intinputthree == intrandomguess)//third try was correct
                    {
                        Console.WriteLine("Congratulations! Your guess was correct!");
                    }
                    else if (10 < intinputthree || intinputthree < 1)//third try was out of range
                    {
                        Console.WriteLine("You can't submit that number and you are out of tries, please try again later!");
                    }
                    else//third try was incorrect
                    {
                        Console.WriteLine("Sorry, but your guess was incorrect! You are out of tries, please try again later!");
                    }
                }
            }
            else //first guess was incorrect
            {
                Console.Write("That number was incorrect, please try another number between 1 and 10: ");
                string strinputtwo = Console.ReadLine();//input for the second try
                int intinputtwo = int.Parse(strinputtwo);//data conversion for second try
                if (intinputtwo == intrandomguess) //second guess was correct
                {
                    Console.WriteLine("Congratulations! Your guess was correct!");
                }
                else if (10 < intinputtwo || intinputtwo < 1)//if second guess was out of range
                {
                    Console.Write("You can't submit that number! Please use a number between 1 and 10: ");
                    string strinputthree = Console.ReadLine();//input for third try
                    int intinputthree = int.Parse(strinputthree);//data conversion for third try
                    if (intinputthree == intrandomguess)//third guess is correct
                    {
                        Console.WriteLine("Congratulations! Your guess was correct!");
                    }
                    else if (10 < intinputthree || intinputthree < 1)//third try was out of range
                    {
                        Console.WriteLine("You can't submit that number and you are out of tries, please try again later!");
                    }
                    else//third try was incorrect
                    {
                        Console.WriteLine("That number was not correct and you are out of tries, please try again later!");
                    }
                }
                else//second input was not correct
                {
                    Console.WriteLine("Your guess was incorrect! Please try again: ");
                    string strinputthree = Console.ReadLine();//third try input
                    int intinputthree = int.Parse(strinputthree);//third try input data conversion
                    if (intinputthree == intrandomguess)//third try was correct
                    {
                        Console.WriteLine("Congratulations! Your guess was correct!");
                    }
                    else if (10 < intinputthree || intinputthree < 1)//third try was out of range
                    {
                        Console.WriteLine("You can't submit that number and you are out of tries, please try again later!");
                    }
                    else//third try was incorrect
                    {
                        Console.WriteLine("Sorry, but your guess was incorrect! You are out of tries, please try again later!");
                    }
                }
            }
        }
    }
}