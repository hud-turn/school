using System;

namespace whileloop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //I used some of the code from the first while loop
            double doubinput = 0;//declaring the variable double input so that the program enters a while loop
            double doubiteration = -1;//this variable will store how many iteration or numbers we have input into the equation. We will use this number later to 
            double doubsumone = +1;//this is the beginning sum that we will divide in order to find the average
            string strA = "A";//this is used with the else if statement to find if A is in the string input
            string strB = "B";//this is used with the else if statement to find if B is in the string input
            string strC = "C";//this is used with the else if statement to find if C is in the string input
            string strD = "D";//this is used with the else if statement to find if D is in the string input
            string strF = "F";//this is used with the else if statement to find if F is in the string input

            Console.Write("Hello!\nThis a grade average calculator. Please input the number of credit hours you are taking: ");
            string strhours = Console.ReadLine();
            double doubhours = double.Parse(strhours);
            while (doubinput != -1)//if doubinput is not equal to 1 it will not launch the program
            {
                doubiteration++;//advances doubiteration by one so we know what we should be dividing by
                Console.Write("Please input the grade you received in your class: ");//Gives user output so they know what they are doing. This line was moved down here so it would repeat and actully look ok.
                string strinput = Console.ReadLine();//getting the users input
                if (strA.Contains(strinput.ToUpper()))//This looks to see if the string contains B and makes sure that the input isn't case sensitive
                {
                    doubinput = 4.0;
                }
                else if (strB.Contains(strinput.ToUpper()))//This looks to see if the string contains B and makes sure that the input isn't case sensitive
                {
                    doubinput = 3.0;
                }
                else if (strC.Contains(strinput.ToUpper()))//This looks to see if the string contains B and makes sure that the input isn't case sensitive
                {
                    doubinput = 2.0;
                }
                else if (strD.Contains(strinput.ToUpper()))//This looks to see if the string contains B and makes sure that the input isn't case sensitive
                {
                    doubinput = 1.0;
                }
                else if (strF.Contains(strinput.ToUpper()))//This looks to see if the string contains B and makes sure that the input isn't case sensitive
                {
                    doubinput = 0.0;
                }
                else//this exits the program if an invalid grade is input
                {
                    doubinput = -1;
                }
                doubsumone = doubsumone + doubinput;//Adding the input to the sum which we can look at later (this was the hard part for me since I was trying to figure out how to sum the vars and it had been a short bit since I had done that last).
            }
            if (doubinput == -1)//if the number is guessed correctly then it will execute the code below. 
            {
                double doubgpa = doubsumone / doubiteration;//Takes the sum and divides it by the iteration in order to figure out the average
                Console.WriteLine("The average grade that you got was " + doubgpa + " points.");//I included the sum in this one so that it would make it easier to debug/fix
                
                if (12 <= doubhours && 3.5 <= doubgpa)//if they have 12 or more credit hours and gpa is 3.5 and above they are placed on the deans list
                {
                    Console.Write("Congratulations, you are eligible to be placed on the Dean's list.");//a congrats that they made the dean's list
                    Console.ReadKey();
                }
                else if (12 <= doubhours && 3.5 > doubgpa)//if they have less than a 3.5 gpa but are at or over 12 credit hours
                {
                    Console.Write("You are not eligible to be placed on the Dean's list, you need to improve your GPA to be eligible.");//telling them how they can get feedback and improve to make the Dean's list.
                    Console.ReadKey();
                }
                else if (12 > doubhours && 3.5 <= doubgpa)//if they are below credit hours but they have a sufficient GPA
                {
                    Console.Write("You are not eligible to be on the Dean's list, you need to have more credit hours to be eligible.");//giving the user feedback and telling them how they can become eligible
                    Console.ReadKey();
                }
                else if (12 > doubhours && 3.5 > doubgpa)//if both GPA and credit hours are below the minimum requirements
                {
                    Console.Write("You are not eligible to be on the Dean's list, you unfortunately will need to improve your GPA and have more credit hours.");
                    Console.ReadKey();
                }
            }

        }
    }
}
