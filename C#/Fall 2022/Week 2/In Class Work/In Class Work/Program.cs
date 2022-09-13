using In_Class_Work;
using System;
namespace In_Class_Work
{
    class Program
    {
        static void Main()
        {
            Student mySelf = new Student("Moe ", "Manshad");
            Console.WriteLine(mySelf.FirstName + mySelf.LastName);
        }
    }
}