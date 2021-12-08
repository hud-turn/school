using System;

namespace elseifstatement5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi there!\nThe purpose of this program is to determine if a number is divisible by 2, 3, 5, 7, 8, or 13 and print out the next 3 numbers.\nPlease input a number: ");
            string strusrinput = Console.ReadLine();
            decimal decusrinput = decimal.Parse(strusrinput);

            decimal decdivtwozero = decusrinput % 2;//this line divides the input for us
            decimal decdivthreezero = decusrinput % 3;//this line divides the input for us
            decimal decdivfivezero = decusrinput % 5;//this line divides the input for us
            decimal decdivsevenzero = decusrinput % 7;//this line divides the input for us
            decimal decdiveightzero = decusrinput % 8;//this line divides the input for us
            decimal decdivthirteenzero = decusrinput % 13;//this line divides the input for us

            if (decdivtwozero == 0)//this line looks to see if the number is divisible.
            {
                decimal decnumtwoone = decusrinput + 2;
                decimal decnumtwotwo = decnumtwoone + 2;
                decimal decnumtwotthree = decnumtwotwo + 2;
                Console.WriteLine("The number is divisible by 2 and the next three numbers are " + decnumtwoone + ", " + decnumtwotwo + ", and " + decnumtwotthree + ".");
            }
            if (decdivthreezero == 0)//this line looks to see if the number is divisible.
            {
                decimal decnumthreeone = decusrinput + 3;
                decimal decnumthreetwo = decnumthreeone + 3;
                decimal decnumtwotthree = decnumthreetwo + 3;
                Console.WriteLine("The number is divisible by 3 and the next three numbers are " + decnumthreeone + ", " + decnumthreetwo + ", and " + decnumtwotthree + ".");
            }
            if (decdivfivezero == 0)//this line looks to see if the number is divisible.
            {
                decimal decdivfiveone = decusrinput + 5;
                decimal decdivfivetwo = decdivfiveone + 5;
                decimal decnumtwotthree = decdivfivetwo + 5;
                Console.WriteLine("The number is divisible by 5 and the next three numbers are " + decdivfiveone + ", " + decdivfivetwo + ", and " + decnumtwotthree + ".");
            }
            if (decdivsevenzero == 0)//this line looks to see if the number is divisible.
            {
                decimal decdivsevenone = decusrinput + 7;
                decimal decdivseventwo = decdivsevenone + 7;
                decimal decdivseventhree = decdivseventwo + 7;
                Console.WriteLine("The number is divisible by 7 and the next three numbers are " + decdivsevenone + ", " + decdivseventwo + ", and " + decdivseventhree + ".");
            }
            if (decdiveightzero == 0)//this line looks to see if the number is divisible.
            {
                decimal decdiveightone = decusrinput + 8;
                decimal decdiveighttwo = decdiveightone + 8;
                decimal decdiveightthree = decdiveighttwo + 8;
                Console.WriteLine("The number is divisible by 8 and the next three numbers are " + decdiveightone + ", " + decdiveighttwo + ", and " + decdiveightthree + ".");
            }
            if (decdivthirteenzero == 0)//this line looks to see if the number is divisible.
            {
                decimal decdivthirteenone = decusrinput + 13;
                decimal decdivthirteentwo = decdivthirteenone + 13;
                decimal decdivthirteenthree = decdivthirteentwo + 13;
                Console.WriteLine("The number is divisible by 13 and the next three numbers are " + decdivthirteenone + ", " + decdivthirteentwo + ", and " + decdivthirteenthree + ".");
            }
            else if (decdivtwozero != 0 && decdivthreezero != 0 && decdivfivezero != 0 && decdivsevenzero != 0 && decdiveightzero != 0 && decdivthirteenzero != 0)//this number looks and if it is not divisible by any of the numbers above then it outputs this
            {
                Console.Write("The number " + decusrinput + " is not divisible by any of these numbers.");
                Console.ReadKey();
            }
        }
    }
}
