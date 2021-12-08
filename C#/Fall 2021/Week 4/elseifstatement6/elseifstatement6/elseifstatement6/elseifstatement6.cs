using System;

namespace elseifstatement6
{
    class elseifstatement6
    {
        static void Main(string[] args)
        {
            Console.Write("Hello! The purpose of this program is to determine if you are eligible to be on the Dean's list.\nPlease input the number of credit hours you are currently taking: ");
            string strhours = Console.ReadLine();//gets user input for the number of credit hours they are taking
            float floathours = float.Parse(strhours);//converts string to float. If the user uses a decimal it will cause the program to error out

            Console.WriteLine("Please input your current GPA: ");//tells uer to input gpa
            string strgpa = Console.ReadLine();//gets user gpa input
            float floatgpa = float.Parse(strgpa);//converts string to float because gpa is typically expressed in decimal format but we don't need something as high level as decimal (which is 16 bytes compared to 4 bytes as far as I can tell)

            if (12 <= floathours && 3.5 <= floatgpa)//if they have 12 or more credit hours and gpa is 3.5 and above they are placed on the deans list
            {
                Console.Write("Congratulations, you are eligible to be placed on the Dean's list.");//a congrats that they made the dean's list
                Console.ReadKey();
            }
            else if (12 <= floathours && 3.5 > floatgpa)//if they have less than a 3.5 gpa but are at or over 12 credit hours
            {
                Console.Write("You are not eligible to be placed on the Dean's list, you need to improve your GPA to be eligible.");//telling them how they can get feedback and improve to make the Dean's list.
                Console.ReadKey();
            }
            else if (12 > floathours && 3.5 <= floatgpa)//if they are below credit hours but they have a sufficient GPA
            {
                Console.Write("You are not eligible to be on the Dean's list, you need to have more credit hours to be eligible.");//giving the user feedback and telling them how they can become eligible
                Console.ReadKey();
            }
            else if (12 > floathours && 3.5 > floatgpa)//if both GPA and credit hours are below the minimum requirements
            {
                Console.Write("You are not eligible to be on the Dean's list, you unfortunately will need to improve your GPA and have more credit hours.");
                Console.ReadKey();
            }
        }
    }
}
