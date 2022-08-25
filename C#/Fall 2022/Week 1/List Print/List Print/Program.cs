using System;
using System.Collections.Generic;

namespace ListPrint
{
    class ListPrint
    {
        static void Main(string[] args)
        {
            List<string> strlst = new List<string> {};//creating the empty list
            strlst.Add("Mike");
            strlst.Add("Rosa");
            strlst.Add("Cal");
            strlst.Add("Janice");
            strlst.Add("Mandy");
            strlst.Add("John");
            strlst.Add("Steve");
            strlst.Add("Fiona");
            strlst.Add("Tanner");
            strlst.Add("Brennan");
            strlst.Sort();
        }
    }
}