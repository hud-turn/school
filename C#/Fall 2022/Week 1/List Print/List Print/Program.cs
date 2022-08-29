using System;
using System.Collections.Generic;

namespace ListPrint
{
    class ListPrint
    {
        static void Main(string[] args)
        {
            int inti = 9;//starting at 9 and counting down
            List<string> strlst = new List<string> {};//creating the empty list
            strlst.Add("Mike");
            strlst.Add("Rosa");
            strlst.Add("Cal");//adding names to the list
            strlst.Add("Janice");
            strlst.Add("Mandy");
            strlst.Add("John");
            strlst.Add("Steve");
            strlst.Add("Fiona");
            strlst.Add("Tanner");
            strlst.Add("Brennan");
            strlst.Sort();//sorting the list alphabetically
            while (inti != -1)//we need to read the space in 0 on the list
            {
                Console.WriteLine(strlst[inti]);//outputting the contents of that specific space in the list
                inti--;//subtracting 1 from inti
            }
            Console.ReadKey();//preventing the program from closing
        }
    }
}