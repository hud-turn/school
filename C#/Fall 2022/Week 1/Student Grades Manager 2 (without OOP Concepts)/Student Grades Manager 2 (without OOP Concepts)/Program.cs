namespace ListPrint
{
    class ListPrint
    {
        static void Main(string[] args)
        {
            List<string> strfirstnamelst = new List<string> {};//creating the empty list
            List<string> strlastnamelst = new List<string> {};//creating the empty list
            List<string> strstud_idlst = new List<string> {};
            List<decimal> decgrdlst = new List<decimal> {};//creating the empty list
            int intuserinput = 0, intidtag = 0;
            decimal decgrdinput = 0, decsum = 0, decdivisor = 0, decmax = decimal.MinValue, decmin = decimal.MaxValue, decgradea = 0, decgradeb = 0, decgradec = 0, decgraded = 0, decgradef = 0;

            string strstu_id = "", strmingrade = "", strmaxgrade = "";
            while (intuserinput != 5)
            {

                Console.WriteLine("Please select one of the following commands to issue:");
                Console.Write("1. Enter Students (id, first name, last name)\n2. Enter Student grade\n3. Remove Students\n4. Grade Analytics\n5. Quit\nWhat would you like to do?: ");//gives the user
                intuserinput = int.Parse(Console.ReadLine());//getting user input
                Console.Clear();//clears terminal
                if (intuserinput == 1)//if the user selects the enter students name and grade option
                {
                    for (int intstudentid = 0, intiterator = 0, intdupe = 0; intstudentid != 1;intiterator++)
                    {
                        Console.Write("Please input the ID of the student you want to add. \nA student ID should start with UNC and contain 9 letters (Between A-F) and numbers.\n\nFor Example:\nUNC351175209\nUNCA0257AFBC\nUNCE7941F7F1\n\nPlease Input the ID for the Student: ");//outputs the student grade average
                        strstu_id = Console.ReadLine();
                        Console.Clear();
                        intdupe = 0;
                        if (strstud_idlst.Contains(strstu_id))
                        {
                            intdupe = 1;
                        }
                        if (intdupe == 0)//checks to see if intiterator is less than 26 and if the letter in the array is the same as the one in the list
                        {
                            strstud_idlst.Add(strstu_id);//adding name to list
                            Console.Clear();//clear
                            Console.WriteLine("Please input the first name of the student you want to add:");//telling user what to do
                            strfirstnamelst.Add(Console.ReadLine());//converts a string to a decimal and then adds it to the decimal list
                            Console.Clear();//clears console
                            Console.WriteLine("Please input the last name of the student you want to add:");//telling user what to do
                            strlastnamelst.Add(Console.ReadLine());//converts a string to a decimal and then adds it to the decimal list
                            decgrdlst.Add(int.Parse(null));
                            Console.WriteLine("Great! You entered the student's information.\nPlease hit enter to return to the main menu");//telling user what to do
                            Console.ReadKey();
                            System.Threading.Thread.Sleep(100);//tells the program to sleep for 100 milliseconds
                            intstudentid = 1;
                        }
                        else if (intdupe == 1)
                        {
                            Console.WriteLine("Please input a non-duplicate Student ID please!\nHit [ENTER] to return to the ID entry menu.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
                else if (intuserinput == 2)//if the user selects the display student grade average
                {
                    //decimal decsuminput = 0;//resets the sum
                    Console.WriteLine("  ID          | Full Name");
                    for (int i = 0; i != strfirstnamelst.Count(); i++)
                    {
                        Console.WriteLine(" " + strstud_idlst[i] + " | " + strfirstnamelst[i] + " " + strlastnamelst[i]);
                    }
                    for(int intstudentid = 0, intiterator = 0; intstudentid !=1;)
                    {
                        if (intiterator == 0)
                        {
                            Console.Write("Please input the Student ID of the grade you want to modify: ");//outputs the student grade average
                            strstu_id = Console.ReadLine();
                        }
                        if (strstu_id.Contains(strstud_idlst[intiterator]))//checks to see if intiterator is less than 26 and if the letter in the array is the same as the one in the list
                        {
                            intidtag = intiterator;
                            intstudentid = 1;
                        }
                        else
                        {
                            intiterator++;
                        }
                    }
                    for(int i = 0; i != 1;)
                    {
                        Console.Write("Please input the grade for the student: ");//outputs the student grade average
                        decgrdinput = decimal.Parse(Console.ReadLine());
                        if (decgrdinput < 100 && decgrdinput > 0 )
                        {
                            decgrdlst[intidtag] = decgrdinput;
                            i = 1;
                        }
                        else
                        {
                            Console.WriteLine("Please input a valid grade between 0-100.");
                            System.Threading.Thread.Sleep(100);//tells the program to sleep for 100 milliseconds
                        }
                        Console.Clear();
                    }
                    System.Threading.Thread.Sleep(100);//tells the program to sleep for 100 milliseconds
                }
                else if (intuserinput == 3)
                {
                    Console.WriteLine("  ID          | Full Name");
                    for (int i = 0; i != strfirstnamelst.Count(); i++)
                    {
                        Console.WriteLine(" " + strstud_idlst[i] + " | " + strfirstnamelst[i] + " " + strlastnamelst[i]);
                    }

                    for (int intstudentid = 0, intiterator = 0; intstudentid != 1;)
                    {
                        if (intiterator == 0)
                        {
                            Console.Write("Please input the Student ID of the grade you want to delete: ");//outputs the student grade average
                            strstu_id = Console.ReadLine();
                        }
                        if (strstu_id.Contains(strstud_idlst[intiterator]))//checks to see if intiterator is less than 26 and if the letter in the array is the same as the one in the list
                        {
                            intidtag = intiterator;
                            intstudentid = 1;
                            strfirstnamelst.Remove(strfirstnamelst[intidtag]);
                            strlastnamelst.Remove(strlastnamelst[intidtag]);
                            strstud_idlst.Remove(strstud_idlst[intidtag]);
                            decgrdlst.Remove(decgrdlst[intidtag]);
                        }
                        else
                        {
                            intiterator++;
                        }
                    }
                }
                else if (intuserinput == 4 )
                {
                    foreach (decimal iter in decgrdlst)
                    {
                        if (iter != null)
                        {
                            decsum += iter;
                            decdivisor++;
                        }
                        
                    }
                    for (int i = 0; i != strstud_idlst.Count();i++)
                    {
                        if (decgrdlst[i] < decmin)
                        {
                            decmin = decgrdlst[i];
                            strmingrade = strfirstnamelst[i] + " " + strlastnamelst[i];
                        }
                        if (decgrdlst[i] > decmax)
                        {
                            decmax = decgrdlst[i];
                            strmaxgrade = strfirstnamelst[i] + " " + strlastnamelst[i];
                        }
                        if(decgrdlst[i]>=90)
                        {
                            decgradea++;
                        }
                        else if(decgrdlst[i]>=80 && decgrdlst[i]<=89)
                        {
                            decgradeb++;
                        }
                        else if (decgrdlst[i] >= 70 && decgrdlst[i] <= 79)
                        {
                            decgradec++;
                        }
                        else if (decgrdlst[i] >= 60 && decgrdlst[i] <= 69)
                        {
                            decgraded++;
                        }
                        else
                        {
                            decgradef++;
                        }
                    }
                    Console.WriteLine("This is the student grade average: " + decgrdlst.Sum()/decgrdlst.Count());
                    Console.WriteLine("This is the lowest grade " + decmin + " and it is " + strmingrade + "'s grade.");
                    Console.WriteLine("This is the highest grade " + decmax + " and it is " + strmaxgrade + "'s grade.");
                    Console.WriteLine(Math.Round(((decgradea / decgrdlst.Count())*100),2) + "% of the class has an A");
                    Console.WriteLine(Math.Round(((decgradeb / decgrdlst.Count()) * 100),2) + "% of the class has a B");
                    Console.WriteLine(Math.Round(((decgradec / decgrdlst.Count()) * 100),2) + "% of the class has a C");
                    Console.WriteLine(Math.Round(((decgraded / decgrdlst.Count()) * 100),2) + "% of the class has a D");
                    Console.WriteLine(Math.Round(((decgradef / decgrdlst.Count()) * 100),2) + "% of the class has a F");
                    Console.ReadKey();
                }
                else if (intuserinput == 5)
                {
                    Console.Clear();//clears console and prevents the else from catching a 5
                }
                else
                {
                    Console.WriteLine("Hello!\n\nYou input an improper number.\nPlease try again and input a number between 1 - 3.\nYou will be returned to the main menu in 3 seconds.");
                    System.Threading.Thread.Sleep(3000);//tells the program to sleep for 3000 milliseconds
                }
                Console.Clear();//clearing terminal
            }
        }
    }
}