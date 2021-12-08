using System;

namespace array3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a word so that the program can calculate the number of vowels in the word: ");//telling the user the purpose of the program
            string strinput = Console.ReadLine();//getting the user input
            string str = strinput.ToLower();//converts the string to uppercase so that the program will accept the input

            char[] stringarray = new char[str.Length];//creating an array that we will output later
            
            //holds the value for the number of times that a vowel appears in the input string
            int intvowelsum = 0;//initializing variables
            
            for (int i = 0; i < str.Length; i++)//moving the string into the array
            {
                stringarray[i] = str[i];//moving the string into an array so that we can reverse the string
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')//if the variable is found in the string it will add 1 to counter associated with that letter
                {
                    intvowelsum++;//adds 1 to the counter to be output at the end of the program
                }
            }
            Array.Reverse(stringarray);//flips the array so that the array now shows up in reverse
            // Printing content of array 
            Console.WriteLine("Word Input: " + str);
            Console.WriteLine("Vowel Count: " + intvowelsum);//giving the user the output
            Console.Write("Word in reverse: ");
            foreach (char i in stringarray) Console.Write(i);//outputting the stringarray now that it has been reversed
            Console.ReadKey();//prevents program from exiting
            //as a side note this page helped me figure out how to use the reverse function in order to flip the word in the array
        }
    }
}
