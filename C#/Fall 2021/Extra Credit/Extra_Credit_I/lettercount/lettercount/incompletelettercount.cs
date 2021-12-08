using System;

namespace lettercount
{
    class incompletelettercount
    {
        static void Main(string[] args)
        {
            Console.Write("Hello! \nPlease input a word so that the program can how many times a specific letter shows up in that word: ");//telling the user the purpose of the program
            string strinput = Console.ReadLine();//getting the user input
            string str = strinput.ToUpper();//converts the string to uppercase so that the program will accept the input

            //initializing variables 
            int inta = 0;//holds the value for the number of times that a letter appears in the input string
            int intb = 0;//holds the value for the number of times that a letter appears in the input string
            int intc = 0;//holds the value for the number of times that a letter appears in the input string
            int intd = 0;//holds the value for the number of times that a letter appears in the input string
            int inte = 0;//holds the value for the number of times that a letter appears in the input string
            int intf = 0;//holds the value for the number of times that a letter appears in the input string
            int intg = 0;//holds the value for the number of times that a letter appears in the input string
            int inth = 0;//holds the value for the number of times that a letter appears in the input string
            int inti = 0;//holds the value for the number of times that a letter appears in the input string
            int intj = 0;//holds the value for the number of times that a letter appears in the input string
            int intk = 0;//holds the value for the number of times that a letter appears in the input string
            int intl = 0;//holds the value for the number of times that a letter appears in the input string
            int intm = 0;//holds the value for the number of times that a letter appears in the input string
            int intn = 0;//holds the value for the number of times that a letter appears in the input string
            int into = 0;//holds the value for the number of times that a letter appears in the input string
            int intp = 0;//holds the value for the number of times that a letter appears in the input string
            int intq = 0;//holds the value for the number of times that a letter appears in the input string
            int intr = 0;//holds the value for the number of times that a letter appears in the input string
            int ints = 0;//holds the value for the number of times that a letter appears in the input string
            int intt = 0;//holds the value for the number of times that a letter appears in the input string
            int intu = 0;//holds the value for the number of times that a letter appears in the input string
            int intv = 0;//holds the value for the number of times that a letter appears in the input string
            int intw = 0;//holds the value for the number of times that a letter appears in the input string
            int intx = 0;//holds the value for the number of times that a letter appears in the input string
            int inty = 0;//holds the value for the number of times that a letter appears in the input string
            int intz = 0;//holds the value for the number of times that a letter appears in the input string 

            int[] intalpha = new int[26] {inta, intb, intc, intd, inte, intf, intg, inth, inti, intj, intk, intl, intm, intn, into, intp, intq, intr, ints, intt, intu, intv, intw, intx, inty, intz };

            char[] ch = new char[str.Length];//creating an array that is the same length as the string

            for (int i = 0; i < str.Length; i++)//moving the string into the array
            {
                if (str[i] == 'A')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    inta++;
                }
                else if (str[i] == 'B')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intb++;
                }
                else if (str[i] == 'C')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intc++;
                }
                else if (str[i] == 'D')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intd++;
                }
                else if (str[i] == 'E')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    inte++;
                }
                else if (str[i] == 'F')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intf++;
                }
                else if (str[i] == 'G')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intg++;
                }
                else if (str[i] == 'H')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    inth++;
                }
                else if (str[i] == 'I')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    inti++;
                }
                else if (str[i] == 'J')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intj++;
                }
                else if (str[i] == 'K')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intk++;
                }
                else if (str[i] == 'L')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intl++;
                }
                else if (str[i] == 'M')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intm++;
                }
                else if (str[i] == 'N')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intn++;
                }
                else if (str[i] == 'O')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    into++;
                }
                else if (str[i] == 'P')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intp++;
                }
                else if (str[i] == 'Q')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intq++;
                }
                else if (str[i] == 'R')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intr++;
                }
                else if (str[i] == 'S')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    ints++;
                }
                else if (str[i] == 'T')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intt++;
                }
                else if (str[i] == 'U')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intu++;
                }
                else if (str[i] == 'V')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intv++;
                }
                else if (str[i] == 'W')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intw++;
                }
                else if (str[i] == 'X')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intx++;
                }
                else if (str[i] == 'Y')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    inty++;
                }
                else if (str[i] == 'Z')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intz++;
                }
            }
            Console.WriteLine("The word " + strinput + " has " + strinput.Length + " characters.");
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write( intalpha[i] + " " + str[i] + "\n");
            }
            Console.ReadKey();//prevents program from exiting
            //I used this source to help me through the homework https://www.geeksforgeeks.org/convert-string-to-character-array-in-c-sharp/
        }
    }
}
