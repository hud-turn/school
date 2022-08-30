using System;
using System.Collections.Generic;//importing the library that allows us to use list

namespace ListPrint
{
    class ListPrint
    {
        static void Main(string[] args)
        {
            List<string> strlst = new List<string> { "Mike", "Rosa", "Cal", "Janice", "Mandy", "John", "Steve", "Fiona", "Tanner", "Brennan" };//creating the empty list
            string userinput;
            //int inti = 9;//starting at 9 and counting down
            foreach(string str in strlst)
            {
                Console.WriteLine(str);//outputting the list
            }
            Console.WriteLine("Please input a name you would like to remove from the list above: ");//telling the user what to input
            userinput = Console.ReadLine();//getting userinput
            Console.Clear();//clearing console to make program cleaner
            for (int i = 0; i != strlst.Count(); i++)
            {
                if(strlst.Contains(userinput))//checking if the list contains a specific word
                {
                    strlst.Remove(userinput);//if the word is in the list then it removes it
                }
            }
            Console.WriteLine("We were able to remove " + userinput + " from the list.\n\nThe list is now:");//tells the word that was removed
            foreach (string str in strlst)
            {
                Console.WriteLine(str);//outputs the list of remaining names
            }
            Console.ReadKey();//preventing the program from closing
        }
    }
}