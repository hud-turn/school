using System;

namespace forloop1
{
    class forloop1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input 10 of your Grades");
            for (double doubiter = 0, doubinput = 0, doubsumone = 0, doubhours = 0 ; doubiter != 10; doubiter++)
            {
                if (doubiter == 0)
                {
                    Console.Write("How Many Credits are you taking:");
                    doubhours = double.Parse(Console.ReadLine());
                }
                Console.Write("Please input the grade you received in your class: ");//Gives user output so they know what they are doing. This line was moved down here so it would repeat and actully look ok.
                string strinput = Console.ReadLine();//getting the users input

                string strA = "A";//this is used with the else if statement to find if A is in the string input
                string strB = "B";//this is used with the else if statement to find if B is in the string input
                string strC = "C";//this is used with the else if statement to find if C is in the string input
                string strD = "D";//this is used with the else if statement to find if D is in the string input
                string strF = "F";//this is used with the else if statement to find if F is in the string input

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
                
                doubsumone = doubsumone + doubinput;//Adding the input to the sum which we can look at later (this was the hard part for me since I was trying to figure out how to sum the vars and it had been a short bit since I had done that last).
                
                if (doubiter == 9)//once the user inputs 10 grades then it will execute this if command
                {
                    double doubgpa = doubsumone / 10;//calculating the gpa
                    Console.WriteLine("At the end of the semester you got a " + doubgpa + " GPA.");//tells the user their gpa
                    if (doubhours >= 12 && doubgpa >= 3.50)
                    {
                        Console.Write("As a result, you have been put on the Dean's List since you are a full time student and have at least a 3.50 GPA.");
                        Console.ReadKey();
                    }
                    else if (doubhours >= 12 && doubgpa < 3.50)
                    {
                        Console.Write("As a result, you are unfortunately ineligible for the Dean's list since you have a " + doubgpa + " GPA which is below the required 3.50 GPA.");
                        Console.ReadKey();
                    }
                    else if (doubhours <= 12 && doubgpa >= 3.50)
                    {
                        Console.Write("As a result, you are unfortuantely ineligible for the Dean's list since you're not a full time student (under 12 credit hours).");
                        Console.ReadKey();
                    }
                    else if (doubhours <= 12 && doubgpa < 3.50)
                    {
                        Console.Write("As a result, you are unfortuantely ineligible for the Dean's list since you're not a full time student and you had a GPA below the 3.50 average.");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
