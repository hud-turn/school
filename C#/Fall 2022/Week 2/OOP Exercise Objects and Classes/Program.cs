using In_Class_Work;
using System;
namespace In_Class_Work
{
    class Program
    {
        static void Main()
        {
            double doubgrade = 0;
            Student mySelf = new Student("Moe ", "Manshad", 10);//myself is the variable and Student is the object
            Student S0 = new Student("S0 ", "S0", 10);
            Student S1 = new Student("S1 ", "S1", 10);
            //Console.WriteLine(mySelf.FirstName+ mySelf.LastName + mySelf.Grade);
            List<Student> strnamelst = new List<Student> { mySelf, S0, S1 };//creating the list and loading objects mySelf, S0, and S1 into the list.
            foreach (Student s in strnamelst)//iterating through every line in strnamelst
            {
                Console.WriteLine(s.FirstName + s.LastName + s.Grade);//printing the output
                doubgrade += s.Grade;
            }
            Console.WriteLine(doubgrade / 3);
            Console.ReadKey();
        }
    }
}