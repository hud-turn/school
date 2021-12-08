using System;
using System.Collections.Generic;//had to add this in order for the list to work since it seems that C# doesn't include list automatically

namespace listi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This program is designed to find the median number that you input.\nPlease input a number between 0-100\nYou can enter -1 to exit the program.\n");//telling the user the function of the program

            List<double> intusrinptlst = new List<double> {};//creating the empty list
            int intusrinpt = 0, intmediani = 0, intmedianii = 0;//assinging values
            double doublemedian = 0, doubmediani = 0, doubmedianii = 0, doublemediancalc = 0, doubleuserinputcount = 0, doubhigher = 0, doublower = 0, doubleuserprocessedhigh = 0, doubleuserprocessedlow = 0;//assinging values

            while (intusrinpt != -1)//will get the users input as long as the input is not -1
            {
                Console.Write("Please input a number: ");
                intusrinpt = int.Parse(Console.ReadLine());//get the users input and convert to int
                if (intusrinpt <= 100 && intusrinpt >= 0)//if the input is between 100-0 then it will add it to the list
                {
                    intusrinptlst.Add(intusrinpt);
                }
                else if (intusrinpt > 100 || intusrinpt < 0 && intusrinpt != -1)//if the input is out of range then it will give the user a warning
                {
                    Console.Write("Please input a number between 0 and 100. \nPlease try again.\n");
                }
            }
            //for (int j = 0; j != intusrinptlst.Count; j++) These lines were used in the debugging of the program to make sure that my add function was operating properly
            //{
                //Console.WriteLine(intusrinptlst[j]);
            //}

            doubleuserinputcount = intusrinptlst.Count;//gets the length of the list so that we can check if the input is even or odd
            doublemedian = doubleuserinputcount % 2;
            if (doublemedian == 0)//if the input is even
            {
                doubleuserprocessedhigh = ((doubleuserinputcount-1) / 2) + 0.1;//finding the higher number out of the two numbers used for the median
                doubmediani = Math.Round(doubleuserprocessedhigh, 0);//converting the median to an integer so we can process it easily in the next step


                doubleuserprocessedlow = ((doubleuserinputcount-1) / 2) - 0.1;//finding the lower number out of the two numbers used for the median
                doubmedianii = Math.Round(doubleuserprocessedlow, 0);//converting the median to an integer so we can process it easily in the next step

                intmediani = Convert.ToInt32(doubmediani);//converting double to int
                intmedianii = Convert.ToInt32(doubmedianii);//converting double to int

                //Console.WriteLine("(" + intmediani + ")"); This line was used in the debugging of the program

                doubhigher = intusrinptlst[intmediani];//median highernumber in integer form
                doublower = intusrinptlst[intmedianii];//median lowernumber in integer form
                doublemediancalc = (doubhigher + doublower);//sum of the two numbers
                Console.WriteLine("The median is: " + doublemediancalc / 2);
                //Console.WriteLine("if"); This line was used in the debugging of the program
                
            }
            else
            {
                intmediani = Convert.ToInt32(Math.Round((doubleuserinputcount-1) / 2));
                Console.Write("The median is: " + intusrinptlst[intmediani]);
                //Console.WriteLine("else"); This line was used in the debugging of the program
            }
        }
    }
}
