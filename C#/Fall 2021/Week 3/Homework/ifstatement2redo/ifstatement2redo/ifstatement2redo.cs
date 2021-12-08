using System;

namespace ifstatement2redo
{
    class ifstatement2redo
    {
        static void Main(string[] args)
        {
            //Generate random number from the computer within the range of 1 and 10 using the random class
            Random rnd = new Random();
            int intrandomguess = rnd.Next(1, 10);

            //Accept user input, also you can just uncomment the line below if you need to test the functionality
            //Console.Write(intrandomguess);
            Console.Write("\nGuess a number between 1 and 10: ");
            string strinputone = Console.ReadLine();//input for first try
            int intinputone = int.Parse(strinputone);//data conversion for first try

            if (intrandomguess > intinputone)//the input is lower than the number that the computer creates
            {
                Console.Write("Whoops! It looks like your guess was too low! Please try again:");
                string strinputtwo = Console.ReadLine();//input for second try
                int intinputtwo = int.Parse(strinputtwo);//data conversion for second try
                if (intrandomguess < intinputtwo)//if the players guess was larger than the computer
                {
                    Console.Write("Whoops! It looks like your guess was too high! Please try again:");
                    string strinputthree = Console.ReadLine();//input for third try
                    int intinputthree = int.Parse(strinputthree);//data conversion for third try
                    if (intrandomguess < intinputthree) //if the players guess was larger than the computer
                    {
                        Console.WriteLine("Whoops! It looks like your guess was too high and you are out of tries!\nBetter luck next time!");
                    }
                    if (intrandomguess > intinputthree)//if the players guess was smaller than the computer
                    {
                        Console.WriteLine("Whoops! It looks like your guess was too low and you are out of tries!\nBetter luck next time!");
                    }
                    if (intrandomguess == intinputthree)//if the player guessed the computers number sucessfully
                    {
                        Console.WriteLine("Nice job! Your guess matched the computers number!");
                    }
                }
                if (intrandomguess > intinputtwo) //if the players guess was smaller than the computer
                {
                    Console.Write("Whoops! It looks like your guess was too low! Please try again:");
                    string strinputthree = Console.ReadLine();//input for third try
                    int intinputthree = int.Parse(strinputthree);//data conversion for third try
                    if (intrandomguess < intinputthree)//if the players guess was larger than the computer
                    {
                        Console.WriteLine("Whoops! It looks like your guess was too high and you are out of tries!\nBetter luck next time!");
                    }
                    if (intrandomguess > intinputthree)//if the players guess was smaller than the computer
                    {
                        Console.WriteLine("Whoops! It looks like your guess was too low and you are out of tries!\nBetter luck next time!");
                    }
                    if (intrandomguess == intinputthree)//if the player guessed the computers number sucessfully
                    {
                        Console.WriteLine("Nice job! Your guess matched the computers number!");
                    }
                }
                if (intrandomguess == intinputtwo)//if the player guessed the computers number sucessfully
                {
                    Console.WriteLine("Nice job! Your guess matched the computers number!");
                }
            }
            if (intrandomguess < intinputone)//the input is higher than the number that the computer creates
            {
                Console.Write("Whoops! It looks like your guess was too high! Please try again:");
                string strinputtwo = Console.ReadLine();//input for second try
                int intinputtwo = int.Parse(strinputtwo);//data conversion for second try
                if (intrandomguess < intinputtwo)//if the players guess was larger than the computers number
                {
                    Console.Write("Whoops! It looks like your guess was too high! Please try again:");
                    string strinputthree = Console.ReadLine();//input for third try
                    int intinputthree = int.Parse(strinputthree);//data conversion for third try
                    if (intrandomguess < intinputthree)//if the players guess was larger than the computer
                    {
                        Console.WriteLine("Whoops! It looks like your guess was too high and you are out of tries!\nBetter luck next time!");
                    }
                    if (intrandomguess > intinputthree)//if the players guess was smaller than the computers number
                    {
                        Console.WriteLine("Whoops! It looks like your guess was too low and you are out of tries!\nBetter luck next time!");
                    }
                    if (intrandomguess == intinputthree)//if the player guessed the computers number sucessfully
                    {
                        Console.WriteLine("Nice job! Your guess matched the computers number!");
                    }
                }
                if (intrandomguess > intinputtwo)
                {
                    Console.Write("Whoops! It looks like your guess was too low! Please try again:");
                    string strinputthree = Console.ReadLine();//input for third try
                    int intinputthree = int.Parse(strinputthree);//data conversion for third try
                    if (intrandomguess < intinputthree)//if the players guess was smaller than the computers number
                    {
                        Console.WriteLine("Whoops! It looks like your guess was too high and you are out of tries!\nBetter luck next time!");
                    }
                    if (intrandomguess > intinputthree)//if the players guess was smaller than the computers number
                    {
                        Console.WriteLine("Whoops! It looks like your guess was too low and you are out of tries!\nBetter luck next time!");
                    }
                    if (intrandomguess == intinputthree)//if the player guessed the computers number sucessfully
                    {
                        Console.WriteLine("Nice job! Your guess matched the computers number!");
                    }
                }
                if (intrandomguess == intinputtwo)
                {
                    Console.WriteLine("Nice job! Your guess matched the computers number!");
                }
            }
            if (intrandomguess == intinputone)//if the player guessed the computers number sucessfully
            {
                Console.WriteLine("Nice job! Your guess matched the computers number!");
            }
        }
    }
}
