using System;

namespace ifstatement4
{
    class ifstatement4
    {
        static void Main(string[] args)
        {
            Console.Write("Hello!\nThis is an overtime and wage calculator, please input the number of hours that you worked for the week:");//Tells the user the purpose of the program.
            string strhours = Console.ReadLine();//user input on these variables.
            double doubhours = double.Parse(strhours);//data conversion on these variables.

            Console.Write("Now, please input the hourly wage/rate you earn at your job:");//tells the user that they need to input the hourly wage.
            string strwage = Console.ReadLine();//user input.
            double doubwage = double.Parse(strwage);//data conversion.

            if (doubhours > 40)//if hours go over 40 then they qualify for overtime.
            {
                double doubovrtimhrs = doubhours - 40;//gets the number of hours over 40 hours.
                double doubovertimwage = doubwage * 1.5;//gets the hourly rate and turns it into what their wage looks like if it is time and a half.
                double doubovertimtotal = doubovrtimhrs * doubovertimwage; //creates the section for the overtime pay and it will add to normal pay.
                double doubnonottotal = 40 * doubwage;//since they worked over 40 hours we can just use their regular pay rate and multiply by 40.
                double doubtotalpay = doubovertimtotal +doubnonottotal;//adding the overtime wage and then the normal wage together.
                Console.WriteLine("You should see $" + doubtotalpay + " as your pre-tax pay on your next paystub.\nHave a good day!");//tells the user what their pay should look like.
                Console.ReadKey();//prevents program from automatically closing
            }
            if (doubhours <= 40)//if hours is lesser than or equal to 40 hours then they don't qualify for over time.
            {
                double doubtotalpay = doubwage * doubhours;//calculating the pre-tax pay.
                Console.WriteLine("You should see $" + doubtotalpay + " as your pre-tax pay on your next paystub.\nHave a good day!");//Tells the user what their pay should look like.
                Console.ReadKey();//prevents program from automatically closing
            }
        }
    }
}
