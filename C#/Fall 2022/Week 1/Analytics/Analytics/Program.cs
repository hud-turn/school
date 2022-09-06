using System;
using System.Collections.Generic;//importing the library that allows us to use list

namespace ListPrint
{
    class ListPrint
    {
        static void Main(string[] args)
        {
            List<double> dbllst = new List<double> {};//creating the empty list
            dbllst.Add(1.5574);
            dbllst.Add(268762);
            dbllst.Add(3.65461);
            dbllst.Add(4.64687);//adding to the empty list
            dbllst.Add(565464);
            dbllst.Add(62138);
            dbllst.Add(7.1654);
            dbllst.Add(8.167);
            dbllst.Add(9.16579);
            dbllst.Add(10.654164);

            double dblsum = 0, dblmax = float.MinValue, dblmin = float.MaxValue;//setting values
            //int inti = 9;//starting at 9 and counting down
            for (int i = 0; i != dbllst.Count(); i++)//for loop to iterate through the list and add it to the sum
            {
                if (dbllst[i] > dblmax)//logic for determining min and max values
                {
                    dblmax = dbllst[i];
                }
                if (dbllst[i] < dblmin)//logic for determining min and max values
                {
                    dblmin = dbllst[i];
                }
                dblsum += dbllst[i];//this adds the list number 
            }
            Console.WriteLine("The average of the list is: " + dblsum/dbllst.Count() + "\nThe minimum number in the list is: " + dblmin + "\nThe maximum number in the list is: " + dblmax);//outputting results
            
            Console.ReadKey();//preventing the program from closing
        }
    }
}