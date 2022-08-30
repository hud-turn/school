using System;
using System.Collections.Generic;//importing the library that allows us to use list

namespace ListPrint
{
    class ListPrint
    {
        static void Main(string[] args)
        {
            List<decimal> declst = new List<decimal> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };//creating the empty list
            decimal decsum = 0;
            //int inti = 9;//starting at 9 and counting down
            Console.WriteLine("Please input a name you would like to remove from the list above: ");//telling the user what to input
            for (int i = 0; i != declst.Count(); i++)
            {
               decsum += declst[i];
            }
            Console.WriteLine(decsum);
            //Console.WriteLine("We were able to remove " + userinput + " from the list.\n\nThe list is now:");//tells the word that was removed
           // foreach (string str in strlst)
            //{
                //Console.WriteLine(str);//outputs the list of remaining names
            //}
            Console.ReadKey();//preventing the program from closing
        }
    }
}