﻿using In_Class_Work;
using System;
namespace In_Class_Work
{
    class Program
    {
        static void Main()
        {
            double doubgrade = 0;
            Student S0 = new Student("Moe ", "Manshad", 10);//myself is the variable and Student is the object
            Student S1 = new Student("S0 ", "S0", 20);
            Student S2 = new Student("S2 ", "S1", 30);
            Student S3 = new Student("S3 ", "S1", 40);
            Student S4 = new Student("S4 ", "S1", 50);
            Student S5 = new Student("S5 ", "S1", 60);
            Student S6 = new Student("S6 ", "S1", 70);
            Student S7 = new Student("S7 ", "S1", 80);
            Student S8 = new Student("S8 ", "S1", 90);
            Student S9 = new Student("S9 ", "S1", 100);
            //Console.WriteLine(mySelf.FirstName+ mySelf.LastName + mySelf.Grade);
            List<Student> strnamelst = new List<Student> {S0, S1, S2, S3, S4, S5, S6, S7, S8, S9 };//creating the list and loading objects mySelf, S0, and S1 into the list.
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