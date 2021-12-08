using System;

namespace ifstatement2
{
    class ifstatement2
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, please input the grade that you received in your class: ");//this tells the user the purpose of the program
            string strinputgrade = Console.ReadLine();//gets users input
            int intinputgrade = int.Parse(strinputgrade);//converts string to int

            if (intinputgrade >= 90)//if input is higher than 90 run this line
            {
                Console.WriteLine("Congratulations you got an A in the class.");
            }
            else if (intinputgrade >= 80)//if input is higher than 80 run this line
            {
                Console.WriteLine("You got a B in the class.");
            }
            else if (intinputgrade >= 70)//if input is higher than 70 run this line
            {
                Console.WriteLine("You got a C in the class.");
            }
            else if (intinputgrade >= 60)//if input is higher than 60 run this line
            {
                Console.WriteLine("You got a D in the class.");
            }
            else//if input is lower than 60 this line will run
            {
                Console.WriteLine("Sorry to say this, but you got an F in the class.");
            }
            //As a quick side note, I know that some of this code is not very verbose and I was only able to do that since the way that it was structured.
            //if it were structured any other way then I would need to include the && condition into the conditions for the else if commands 
        }
    }
}
