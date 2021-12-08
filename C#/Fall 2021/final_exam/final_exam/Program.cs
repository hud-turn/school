using System;
using System.Collections.Generic;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string strmenuinput = null, strmenuinputlower = null, struserinput = null, strA = "A", strB = "B", strC = "C";//declaring and intializing values
            int intindex = 0, intlongwordindex = -1, intshortwordindex = -1, intsmallestword = int.MaxValue, intlargestword = int.MinValue, intstruserinputlength = 0, intmediani = 0, intmedianii = 0;//declaring and intializing values
            double doublemedian = 0, doubmediani = 0, doubmedianii = 0, doublemediancalc = 0, doubleuserinputcount = 0, doubhigher = 0, doublower = 0, doubleuserprocessedhigh = 0, doubleuserprocessedlow = 0;//declaring and intializing values

            List<string> struserinputlist = new List<string>();//declaring the string

            while (strmenuinput != strC)//creating a while loop so that the only way to exit is for the user to say they want to exit
            {
                Console.Write("Main Menu:\n\nA.Practice\nB.Analytics\nC.Quit\nWhat do you want to do? ");//telling the user their options
                strmenuinputlower = Console.ReadLine();//getting user input
                strmenuinput = strmenuinputlower.ToUpper();//converting the string to upper so it reduces headaches in the future
                if (strA.Contains(strmenuinput))
                {
                    Console.Clear();//clearing the screen to reduce clutter
                    Console.Write("Please input a word that you would like to add to a list: ");
                    struserinput = Console.ReadLine();//getting the users input
                    struserinputlist.Add(struserinput);//adding the string to the list of inputs
                    Console.WriteLine("The word has been entered. Hit the [Enter] key to return to the main menu.");//telling the user what to do next
                    Console.ReadKey();//stopping the terminal output so the user can read the output
                    Console.Clear();//clearing the screen to reduce clutter

                    intstruserinputlength = struserinput.Length;//getting the user input length
                    if (intstruserinputlength > intlargestword)//looking to see if the users input is larger than the largest word
                    {
                        intlargestword = intstruserinputlength;//it is replacing the largest word with the input the user created
                        intlongwordindex = intindex;//getting the largest word and indexing it for later use
                    }
                    if (intstruserinputlength < intsmallestword)//looking to see if the users input is smaller than the smallest word on record so far
                    {
                        intsmallestword = intstruserinputlength;//it is replacing the smallest word with the input the user created
                        intshortwordindex = intindex;//getting the smallest word and indexing it for later use
                    }
                    intindex++;//increasing the index by one
                }
                else if (strB.Contains(strmenuinput) && intindex != 0)//if the user has input b and has at least entered one word then it will run this command. The program would error out if you press b on the first try if I had more time I probably would have implemented a function where it would tell you that you need to enter a number first before entering b.
                {
                    Console.Clear();//clearing terminal to reduce clutter
                    Console.WriteLine("The longest word entered was " + struserinputlist[intlongwordindex] + " and  the length of this word was " + struserinputlist[intlongwordindex].Length + " characters long");//outputting the indexed and length
                    Console.WriteLine("The shortest word entered was " + struserinputlist[intshortwordindex] + " and  the length of this word was " + struserinputlist[intshortwordindex].Length + " characters long");//outputting the indexed and length

                    doubleuserinputcount = struserinputlist.Count;//gets the length of the list so that we can check if the input is even or odd
                    doublemedian = doubleuserinputcount % 2;//using modulo to see if the output is clean or not
                    if (doublemedian == 0)//if the input is even
                    {
                        doubleuserprocessedhigh = ((doubleuserinputcount - 1) / 2) + 0.1;//finding the higher number out of the two numbers used for the median
                        doubmediani = Math.Round(doubleuserprocessedhigh, 0);//converting the median to an integer so we can process it easily in the next step


                        doubleuserprocessedlow = ((doubleuserinputcount - 1) / 2) - 0.1;//finding the lower number out of the two numbers used for the median
                        doubmedianii = Math.Round(doubleuserprocessedlow, 0);//converting the median to an integer so we can process it easily in the next step

                        intmediani = Convert.ToInt32(doubmediani);//converting double to int
                        intmedianii = Convert.ToInt32(doubmedianii);//converting double to int

                        //Console.WriteLine("(" + intmediani + ")"); This line was used in the debugging of the program

                        doubhigher = Convert.ToInt32(struserinputlist[intmediani].Length);//median highernumber in integer form
                        doublower = Convert.ToInt32(struserinputlist[intmedianii].Length);//median lowernumber in integer form
                        doublemediancalc = (doubhigher + doublower);//sum of the two numbers
                        Console.WriteLine("fi");
                        Console.WriteLine("The median is: " + doublemediancalc / 2);
                        //Console.WriteLine("if"); This line was used in the debugging of the program

                    }
                    else
                    {
                        intmediani = Convert.ToInt32(Math.Round((doubleuserinputcount - 1) / 2));//getting the first median
                        Console.WriteLine("else");
                        Console.Write("The median is: " + struserinputlist[intmediani].Length);//getting the length of the median
                        //Console.WriteLine("else"); This line was used in the debugging of the program
                    }
                    Console.ReadKey();//letting the user see the output of the program
                    Console.Clear();//clearing screen to reduce clutter
                }
                else if (strmenuinput != strC)//if the user input does not equal c it will automagically run this else if. I wanted it to have some form of user feedback instructing the user how to use the program properly
                {
                    Console.Clear();//clearing screen to reduce clutter
                    Console.WriteLine("Whoops! You input an invalid value! Please try again and input a valid value!\nPlease press [Enter] to return to the main menu.");
                    Console.ReadKey();//letting the user see the output of the program
                    Console.Clear();//clearing screen to reduce clutter
                }
            }
        }
    }
}
