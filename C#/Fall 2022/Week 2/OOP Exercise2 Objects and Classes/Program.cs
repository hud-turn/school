using OOP_Exercise2_Objects_and_Classes;
using System;
namespace OOP_Exercise2_Objects_and_Classes//namespace
{
    class Program//class
    {
        static void Main()
        {
            char passthru = ' ';//initializing the variable passthru so that we can put it into text later
            
            Student S0 = new Student("S0 ", "S1", 10);//S0 is the variable and Course is the object
            //If I wanted to modify S0 I could do S0.FirstName = "Joe";
            Student S1 = new Student("S1 ", "S1", 20);
            Student S2 = new Student("S2 ", "S1", 30);
            Student S3 = new Student("S3 ", "S1", 40);
            Student S4 = new Student("S4 ", "S1", 50);
            Student S5 = new Student("S5 ", "S1", 60);
            Student S6 = new Student("S6 ", "S1", 70);
            Student S7 = new Student("S7 ", "S1", 80);
            Student S8 = new Student("S8 ", "S1", 90);
            Student S9 = new Student("S9 ", "S1", 100);
            //Console.WriteLine(mySelf.FirstName+ mySelf.LastName + mySelf.Grade);
            List<Student> strnamelst = new List<Student> {S0, S1, S2, S3, S4, S5, S6, S7, S8, S9 };//creating the list and loading objects mySelf, S0, and S1 into the list
            Course test = new Course("Test","123",strnamelst);

            Console.Write("Please input the grade you want to look for: ");
            passthru = char.ToUpper(char.Parse(Console.ReadLine()));
            Console.WriteLine("The average grade is: " + test.GradeAverage() + "\nThe minimum grade is: " + test.GradeMin() + "\nThe maximum grade is: " + test.GradeMax() + "\nThe % of people with a " + passthru + " is " + test.GradePercent(passthru) + "%");
            Console.ReadKey();
        }
    }
}