using System;
using System.Collections.Generic;//had to add this in order for the list to work since it seems that C# doesn't include list automatically
namespace listii
{
    class Program
    {
        static void Main(string[] args)
        {
            int intuserinput = 0, intusertries = 0, intuserguess = 0, intrandomguess = 0, intlistsum = 0, intmediani = 0, intmedianii = 0;//creating the int variables
            double doublargestnum = double.MinValue, doubsmallestnum = double.MaxValue, doubaverageinpt = 0, doubmedian = 0, doubmediani = 0, doubmedianii = 0, doubuserinputcount = 0, doubuserprocessedhigh = 0, doubhigher = 0, doubuserprocessedlow = 0, doublower = 0, doubmediancalc = 0;//creating the double variables

            List<double> doubusrinptlst = new List<double> { };//creating the empty list

            Random rnd = new Random();//importing pseudorandom generator in order to create a number between 1-100
            intrandomguess = rnd.Next(1, 100);//assigning a value to the random guess

            while (intuserinput != 3)
            {
                doubusrinptlst.Sort();//sorts/re-orders the list so that the median will be accurate, I put it here since it will refresh the sorting of the list everytime a variable is input and the user returns to this page
                Console.Write("You can have three options you can select from:\n1) Guess a number\n2) Analytics\n3) Exit the program\nWhat do you want to do: ");
                intuserinput = Convert.ToInt32(Console.ReadLine());//taking the users input and converting it into int

                if (intuserinput == 1)//guess a number
                {
                    Console.Clear();//Clears the screeen so that the input looks neater
                    Console.Write("Please guess a number between 1 - 100.\nWhat number will you guess?: ");
                    intuserguess = Convert.ToInt32(Console.ReadLine());//taking the input
                    intusertries++;//adding to the user tries

                    //Console.WriteLine(intuserguess);These lines were used in the debugging of the program
                    //Console.ReadKey();

                    if (intuserguess == intrandomguess)
                    {
                        Console.WriteLine("Congratulations! You guessed the number correctly! Hit Enter to return to the menu.");
                        doubusrinptlst.Add(intuserguess);//adds the guess to the list
                        if (intuserguess > doublargestnum)//looking to see if the user's guess is larger then the largest number on record so far
                        {
                            doublargestnum = intuserguess;
                        }
                        if (intuserguess < doubsmallestnum)//looking to see if the user's guess is smaller then the smallest number on record so far
                        {
                            doubsmallestnum = intuserguess;
                        }
                    }
                    if (intuserguess < intrandomguess)//filtering out results
                    {
                        doubusrinptlst.Add(intuserguess);//adds the guess to the list
                        if (intuserguess >= 1 && intuserguess <= 100)//if the user submitted a number within the 1-100 range it will use this if condition
                        {
                            Console.WriteLine("You guessed a too low. Please try again later. Hit Enter to return to the menu.");
                            if (intuserguess > doublargestnum)//looking to see if the user's guess is larger then the largest number on record so far
                            {
                                doublargestnum = intuserguess;//moving the guess into the variable so it can be stored for later analytics
                            }
                            if (intuserguess < doubsmallestnum)//looking to see if the user's guess is smaller then the smallest number on record so far
                            {
                                doubsmallestnum = intuserguess;//moving the guess into the variable so it can be stored for later analytics
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your guess was too low and out of range. Please try again later. Hit Enter to return to the menu.");//telling the user that they messed up by submitting a number out of range
                        }
                    }
                    if (intuserguess > intrandomguess)//filtering out results
                    {
                        doubusrinptlst.Add(intuserguess);//adds the guess to the list
                        if (intuserguess >= 1 && intuserguess <= 100)//if the user submitted a number within the 1-100 range it will use this if condition
                        {
                            Console.WriteLine("You guessed a too high. Please try again later. Hit Enter to return to the menu.");
                            if (intuserguess > doublargestnum)//looking to see if the user's guess is larger then the largest number on record so far
                            {
                                doublargestnum = intuserguess;//moving the guess into the variable so it can be stored for later analytics
                            }
                            if (intuserguess < doubsmallestnum)//looking to see if the user's guess is smaller then the smallest number on record so far
                            {
                                doubsmallestnum = intuserguess;//moving the guess into the variable so it can be stored for later analytics
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your guess was too high and out of range. Please try again later. Hit Enter to return to the menu.");//telling the user that they messed up by submitting a number out of range
                        }
                    }
                    Console.ReadKey();//lets the user control when the screen clears
                    Console.Clear();//Clears the screeen so that the input looks neater
                }
                else if (intuserinput == 2)//analytics
                {
                    Console.Clear();//clears the terminal so that the formatting looks nice

                    if (doublargestnum == double.MinValue && doubsmallestnum == double.MaxValue)
                    {
                        Console.WriteLine("You have not entered any numbers yet. \nPlease enter some numbers and then return to this analytics page.\nPlease hit enter to return to the main menu.");
                        Console.ReadKey();//give the user a chance to read the terminal output before the terminal clears in the next command
                        Console.Clear();//clears the terminal so that the formatting looks nice
                    }
                    else if (doublargestnum != double.MinValue && doubsmallestnum != double.MaxValue)//looks to see if the user has input anything into the list
                    {
                        Console.WriteLine("You have chosen to look at the analytics for this program. Here are the analytics.\n");
                        Console.WriteLine("The largest number you input was: " + doublargestnum);//outputting the largest number
                        Console.WriteLine("The smallest number you input was: " + doubsmallestnum);//outputting the smallest number

                        //calculating the average here
                        for (int intlistlength = 0; intlistlength != doubusrinptlst.Count; intlistlength++)
                        {
                            intlistsum += Convert.ToInt32(doubusrinptlst[intlistlength]);
                        }
                        doubaverageinpt = intlistsum / doubusrinptlst.Count;//creating the average input
                        Console.WriteLine("The average number that you input was: " + doubaverageinpt);//gets the average input

                        //number of times the user tried to guess the number
                        Console.WriteLine("Times you have tried to guess the number " + intusertries + " times.");//outputs the number of times the user has tried to guess the number

                        //this portion is for the median 
                        doubuserinputcount = doubusrinptlst.Count;//gets the length of the list so that we can check if the input is even or odd
                        doubmedian = doubuserinputcount % 2;
                        if (doubmedian == 0)//if the input is even
                        {
                            doubuserprocessedhigh = ((doubuserinputcount - 1) / 2) + 0.1;//finding the higher number out of the two numbers used for the median
                            doubmediani = Math.Round(doubuserprocessedhigh, 0);//converting the median to an integer so we can process it easily in the next step


                            doubuserprocessedlow = ((doubuserinputcount - 1) / 2) - 0.1;//finding the lower number out of the two numbers used for the median
                            doubmedianii = Math.Round(doubuserprocessedlow, 0);//converting the median to an integer so we can process it easily in the next step

                            intmediani = Convert.ToInt32(doubmediani);//converting doub to int
                            intmedianii = Convert.ToInt32(doubmedianii);//converting doub to int

                            //Console.WriteLine("(" + intmediani + ")"); This line was used in the debugging of the program

                            doubhigher = doubusrinptlst[intmediani];//median highernumber in integer form
                            doublower = doubusrinptlst[intmedianii];//median lowernumber in integer form
                            doubmediancalc = (doubhigher + doublower);//sum of the two numbers
                            Console.WriteLine("The median is: " + doubmediancalc / 2);
                            //Console.WriteLine("if"); This line was used in the debugging of the program

                        }
                        else
                        {
                            intmediani = Convert.ToInt32(Math.Round((doubuserinputcount - 1) / 2));//getting the median for an odd numbered list
                            Console.WriteLine("The median is: " + doubusrinptlst[intmediani]);
                            //Console.WriteLine("else"); This line was used in the debugging of the program
                        }
                        Console.WriteLine("\nPlease press enter to return to the main menu.");
                        Console.ReadKey();//lets the user control when the screen clears
                        Console.Clear();//Clears the screeen so that the input looks neater
                    }
                }
                else if (intuserinput == 3)
                {
                    Console.WriteLine("\nYou have chosen to exit the program, have a good day!");//confirms the users choice
                    Console.ReadKey();//Prevents the program from shutting down without displaying the goodbye message
                }
                else//if the user inputs an invalid number
                {
                    Console.Clear();//Clears the screeen so that the input looks neater
                    Console.WriteLine("You have entered an invalid option, please hit enter to return to the main menu.");//tells the user that they have messed up and returns them to the menu
                    Console.ReadKey();//lets the user control when the screen clears
                    Console.Clear();//Clears the screeen so that the input looks neater
                }
            }
        }
    }
}