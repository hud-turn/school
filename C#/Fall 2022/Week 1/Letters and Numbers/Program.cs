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
            int inttest = strinput.Length, inttotal = 0, iq = 0, test = 0;//setting parametrs for the program

            List<string> stringlist = new List<string> { };//creating a list that we load the user input into
            List<char> letters = new List<char> {};//creating the alphabet and also allowing for spaces in the word
            List <int> numbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025};//creating the list of fibonnaci numbers
            for (char c = 'a'; c <= 'z'; c++)
            {
                letters.Add(c);//do something with letter 
            }

            for (int inte = 0; inte < str.Length; inte++)//moving the string into the array
            {
                stringlist.Add(Char.ToString(str[inte])); //moving the string into an array so that we can compare it
            }
            //Console.ReadKey();
            while (inttest != test)
            {
                if (iq < 26 && stringlist[test].Contains(letters[iq]))//checks to see if iq is less than 26 and if the letter in the array is the same as the one in the list
                {
                    //Console.WriteLine("Letters: " + letters[iq] + "| " + numbers[iq]);
                    inttotal += numbers[iq];
                    test++;
                }
                if (iq == 26)//this will detect if we have reached the end of the alphabet
                {
                    iq = -1;//this will reset iq so that we don't go out of range
                }
                iq++;
                //Console.WriteLine("Inttotal" + inttotal); This was here for testing
                //Console.ReadKey(); This was here for testing
            }
            Console.WriteLine("The Fibonacci Number for this word " + strinput + " is: " + inttotal);//Tells the user the number of the word
            Console.ReadKey();//Prevents program from exiting
         }   
    }
}
