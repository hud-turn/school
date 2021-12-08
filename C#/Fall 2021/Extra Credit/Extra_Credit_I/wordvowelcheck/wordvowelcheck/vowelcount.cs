using System;

namespace wordvowelcheck
{
    class vowelcount
    {
        static void Main(string[] args)
        {
            Console.Write("Hello! \nPlease input a word so that the program can calculate the number of vowels in the word: ");//telling the user the purpose of the program
            string strinput = Console.ReadLine();//getting the user input
            string str = strinput.ToUpper();//converts the string to uppercase so that the program will accept the input

            int inta = 0;//holds the value for the number of times that a vowel appears in the input string
            int inte = 0;//holds the value for the number of times that a vowel appears in the input string
            int inti = 0;//holds the value for the number of times that a vowel appears in the input string
            int into = 0;//holds the value for the number of times that a vowel appears in the input string
            int intu = 0;//holds the value for the number of times that a vowel appears in the input string
 
            char[] ch = new char[str.Length];//creating an array that is the same length as the string

            for (int i = 0; i < str.Length; i++)//moving the string into the array
            {
                if (str[i] == 'A')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    inta++;
                }
                else if (str[i] == 'E')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    inte++;
                }
                else if (str[i] == 'I')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    inti++;
                }
                else if (str[i] == 'O')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    into++;
                }
                else if (str[i] == 'U')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intu++;
                }
            }
            // Printing content of array 
            int intvowelsum = inta + inte + inti + into + intu;//counting how many vowels were added to the iterators
            Console.WriteLine("There are " + intvowelsum + " vowels in the word you put in.");//giving the user the output
            Console.ReadKey();//prevents program from exiting
            //I used this source to help me through the homework https://www.geeksforgeeks.org/convert-string-to-character-array-in-c-sharp/
        }
    }
}
