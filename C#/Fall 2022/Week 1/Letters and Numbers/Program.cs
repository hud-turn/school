using System;

namespace lettersandnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a word so that the program can calculate the number of the word using the fibonacci sequence: ");//telling the user the purpose of the program
            string strinput = Console.ReadLine();//getting the user input
            string str = strinput.ToLower();//converts the string to uppercase so that the program will accept the input
            int inttest = strinput.Length;
            int inttotal = 0, iq = 0, test = 0;
            string[] stringarray = new string[str.Length];//creating an array that we will output later
            char[] letters = { 'a', 'b', 'c', 'd','e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p','q','r','s','t','u','v','w','x','y','z'};
            int[] numbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4781, 6765, 10946, 17711, 28657, 46368, 75025};
            for (int inte = 0; inte < str.Length; inte++)//moving the string into the array
            {
                stringarray[inte] = Char.ToString(str[inte]);//moving the string into an array so that we can reverse the string
            }
            Console.ReadKey();
            while (inttest != test)
            {
                //Console.WriteLine("Letters: " + letters[iq]);
                //Console.WriteLine("Numbers" + numbers[iq]);
                if (iq < 25 && stringarray[test].Contains(letters[iq]))
                {
                    inttotal += numbers[iq];
                    test++;
                }
                if (iq == 25)
                {
                    iq = -1;
                }
                iq++;
                //Console.WriteLine("Inttotal" + inttotal);
                //Console.ReadKey();
            }
            Console.WriteLine(inttotal);
            Console.ReadKey();
         }   
    }
}
