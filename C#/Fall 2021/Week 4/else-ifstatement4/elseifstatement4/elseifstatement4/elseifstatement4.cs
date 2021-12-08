using System;

namespace elseifstatement4
{
    class elseifstatement4
    {
        static void Main(string[] args)
        {
            Console.Write("This is a Spanish translator, please input the word you want to translate: ");//This lets the user know what the function of the program is
            string userinput = Console.ReadLine();//this gets the users input

            if (userinput == "Beautiful")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Bella in spanish.");
            }
            else if (userinput == "Country")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Pais in spanish.");
            }
            else if (userinput == "Dancing")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Bailando in spanish.");
            }
            else if (userinput == "Day")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Día in spanish.");
            }
            else if (userinput == "Example")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Ejemplo in spanish.");
            }
            else if (userinput == "Goodbye")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Adios in spanish.");
            }
            else if (userinput == "Hello")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Hola in spanish.");
            }
            else if (userinput == "House")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Casa in spanish.");
            }
            else if (userinput == "Life")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Vida in spanish.");
            }
            else if (userinput == "Man")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Hombre in spanish.");
            }
            else if (userinput == "Moment")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Momento in spanish.");
            }
            else if (userinput == "No")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to No in spanish.");
            }
            else if (userinput == "People")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Gente and Personas in spanish.");
            }
            else if (userinput == "Place")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Lugar in spanish.");
            }
            else if (userinput == "Please")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Por Favor in spanish.");
            }
            else if (userinput == "Slowly")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Despacito in spanish.");
            }
            else if (userinput == "Things")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Cosas in spanish.");
            }
            else if (userinput == "What")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Que in spanish.");
            }
            else if (userinput == "Where")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Donde in spanish.");
            }
            else if (userinput == "Who")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Quien in spanish.");
            }
            else if (userinput == "Woman")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Mujer in spanish.");
            }
            else if (userinput == "Work")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Trabajo in spanish.");
            }
            else if (userinput == "World")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Mundo in spanish.");
            }
            else if (userinput == "Years")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Anos in spanish.");
            }
            else if (userinput == "Yes")//if user string Equals this then it will print the line below
            {
                Console.WriteLine(userinput + " translates to Si in spanish.");
            }
            else//if user string is not recognized in any of the above strings then it will fail to translate the spanish phrase.
            {
                Console.WriteLine("Sorry! I do not understand!");
            }
        }
    }
}
