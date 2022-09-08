using System;
using System.Collections.Generic;//importing the library that allows us to use list
using static System.Net.Mime.MediaTypeNames;

namespace ListPrint
{
    class ListPrint
    {
        static void Main(string[] args)
        {
            List<string> strfirstnamelst = new List<string> { };//creating the empty list
            List<string> strlastnamelst = new List<string> { };//creating the empty list
            List<string> strstud_idlst = new List<string> { };
            List<decimal> decgrdlst = new List<decimal> { };//creating the empty list
            int intuserinput = 0, intiterator;
            string strstu_id;
            while (intuserinput != 5)
            {

                Console.WriteLine("Please select one of the following commands to issue:");
                Console.Write("1. Enter Students (id, first name, last name)\n2. Enter Student grade\n3. Remove Students\n4. Grade Analytics\n5. Quit\nWhat would you like to do?: ");//gives the user
                intuserinput = int.Parse(Console.ReadLine());//getting user input
                if (intuserinput == 1)//if the user selects the enter students name and grade option
                {
                    Console.Clear();//clears terminal
                    Console.WriteLine("Please input the ID of the student you want to add. \nA student ID should start with UNC and contain 9 letters (Between A-F) and numbers.\n\nFor Example:\nUNC351175209\nUNCA0257AFBC\nUNCE7941F7F1\n\nPlease Input the ID for the Student: ");//tells the user how to use the program
                    strstud_idlst.Add(Console.ReadLine());//adding name to list
                    Console.Clear();//clear
                    Console.WriteLine("Please input the first name of the student you want to add:");//telling user what to do
                    strfirstnamelst.Add(Console.ReadLine());//converts a string to a decimal and then adds it to the decimal list
                    Console.Clear();//clears console
                    Console.WriteLine("Please input the last name of the student you want to add:");//telling user what to do
                    strlastnamelst.Add(Console.ReadLine());//converts a string to a decimal and then adds it to the decimal list
                    decgrdlst.Add(-500);
                    Console.WriteLine("Great! You entered the student's information.\nPlease hit enter to return to the main menu");//telling user what to do
                    Console.ReadKey();
                    System.Threading.Thread.Sleep(100);//tells the program to sleep for 100 milliseconds
                }
                else if (intuserinput == 2)//if the user selects the display student grade average
                {
                    Console.Clear();//clears terminal
                    //decimal decsuminput = 0;//resets the sum
                    Console.WriteLine("  ID          | Full Name");
                    for (int i = 0; i != strfirstnamelst.Count(); i++)
                    {
                        Console.WriteLine(" " + strstud_idlst[i] + " | " + strfirstnamelst[i] + " " + strlastnamelst[i]);
                    }
                    Console.WriteLine("Please input the Student ID of the grade you want to modify: ");//outputs the student grade average
                    strstu_id = Console.ReadLine();
                    intiterator = 0;
                    foreach (string strstudentid in strstud_idlst)
                    {
                        if (intiterator != 12 && strstud_idlst[intiterator].Contains(strstudentid))//checks to see if intiterator is less than 26 and if the letter in the array is the same as the one in the list
                        {
                            for(int i = 0; i != 503;)
                            {
                                Console.WriteLine("Please input the grade for " + strfirstnamelst[intiterator] + strlastnamelst[intiterator] + " :");
                                decgrdlst[intiterator] = decimal.Parse(Console.ReadLine());
                                if (decgrdlst[intiterator] > 100 || decgrdlst[intiterator] < 0)
                                {
                                    Console.Clear();
                                    Console.Write("Please input a valid number between 0 and 100.\nPlease input a new grade");
                                    decgrdlst[intiterator] = decimal.Parse(Console.ReadLine());
                                    Console.Clear();
                                }
                                else
                                {
                                    i = 503;
                                }
                            }
                        }
                        if (intiterator == 12)//this will detect if we have reached the end of the alphabet
                        {
                            intiterator = -1;//this will reset intiterator so that we don't go out of range
                        }
                        intiterator++;
                        //Console.WriteLine("Inttotal" + inttotal); This was here for testing
                        //Console.ReadKey(); This was here for testing
                    }
                    System.Threading.Thread.Sleep(100);//tells the program to sleep for 3000 milliseconds
                }
                else if (intuserinput == 3)
                {
                   
                }
                else if (intuserinput == 4 )
                {

                }
                else if (intuserinput == 5)
                {
                    Console.Clear();//clears console and prevents the else from catching a 5
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hello!\n\nYou input an improper number.\nPlease try again and input a number between 1 - 3.\nYou will be returned to the main menu in 3 seconds.");
                    System.Threading.Thread.Sleep(3000);//tells the program to sleep for 3000 milliseconds
                }
                Console.Clear();//clearing terminal
            }
        }
    }
}