using System;
using System.Collections.Generic;//importing the library that allows us to use list

namespace ListPrint
{
    class ListPrint
    {
        static void Main(string[] args)
        {
            List<float> fltlst = new List<float> {};//creating the empty list
            fltlst.Add(1);
            fltlst.Add(2);
            fltlst.Add(3);
            fltlst.Add(4);//adding to the empty list
            fltlst.Add(5);
            fltlst.Add(6);
            fltlst.Add(7);
            fltlst.Add(8);
            fltlst.Add(9);
            fltlst.Add(10);

            float fltsum = 0, fltmax = float.MinValue, fltmin = float.MaxValue;//setting values
            //int inti = 9;//starting at 9 and counting down
            for (int i = 0; i != fltlst.Count(); i++)//for loop to iterate through the list and add it to the sum
            {
                if (fltlst[i] > fltmax)
                {
                    fltmax = fltlst[i];
                }
                if (fltlst[i] < fltmin)
                {
                    fltmin = fltlst[i];
                }
                fltsum += fltlst[i];//this adds the list number 
            }
            Console.WriteLine(fltsum/fltlst.Count() + " " + fltmin + " " + fltmax);
            
            Console.ReadKey();//preventing the program from closing
        }
    }
}