using System;

namespace elseifstatement3
{
    class elseifstatement3
    {
        static void Main(string[] args)
        {
            Console.Write("This is a race time evaluator, please input the name of first person you would like to compare: ");//This line tells the user which runner they are inputing
            string strrunnameone = Console.ReadLine();//gets the input for the runners name
            Console.Write("Please input the number of seconds it took them to run the race: ");
            string strrtone = Console.ReadLine();//gets the input for the runners time
            int intrtone = int.Parse(strrtone);//converts runners time into int data type
            
            Console.Write("\nThis is a marathon time evaluator, please input the name of second person you would like to compare: ");//This line tells the user which runner they are inputing
            string strrunnametwo = Console.ReadLine();//gets the input for the runners name
            Console.Write("Please input the number of seconds it took them to run the race: ");
            string strrttwo = Console.ReadLine();//gets the input for the runners time
            int intrttwo = int.Parse(strrttwo);//converts runners time into int data type

            Console.Write("\nThis is a marathon time evaluator, please input the name of third person you would like to compare: ");//This line tells the user which runner they are inputing
            string strrunnamethree = Console.ReadLine();//gets the input for the runners name
            Console.Write("Please input the number of seconds it took them to run the race: ");
            string strrtthree = Console.ReadLine();//gets the input for the runners time
            int intrtthree = int.Parse(strrtthree);//converts runners time into int data type

            Console.Write("\nThis is a marathon time evaluator, please input the name of fourth person you would like to compare: ");//This line tells the user which runner they are inputing
            string strrunnamefour = Console.ReadLine();//gets the input for the runners name
            Console.Write("Please input the number of seconds it took them to run the race: ");
            string strrtfour = Console.ReadLine();//gets the input for the runners time
            int intrtfour = int.Parse(strrtfour);//converts runners time into int data type

            if (intrtone < intrttwo && intrtone < intrtthree && intrtone < intrtfour)//if runner one is the fastest it outputs the following line
            {
                Console.WriteLine("Well it appears that " + strrunnameone + " was the fastest runner.");
            }
            else if (intrttwo < intrtone && intrttwo < intrtthree && intrttwo < intrtfour)//if runner two is the fastest it outputs the following line
            {
                Console.WriteLine("Well it appears that " + strrunnametwo + " was the fastest runner.");
            }
            else if (intrtthree < intrtone && intrtthree < intrttwo && intrtthree < intrtfour)//if runner three is the fastest it outputs the following line
            {
                Console.WriteLine("Well it appears that " + strrunnamethree + " was the fastest runner.");
            }
            else if (intrtfour < intrtone && intrtfour < intrttwo && intrtfour < intrtthree)//if runner four is the fastest it outputs the following line
            {
                Console.WriteLine("Well it appears that " + strrunnamefour + " was the fastest runner.");
            }
        }
    }
}
