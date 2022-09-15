using Exercise_2;
using In_Class_Work;
using System;
namespace In_Class_Work
{
    class Program
    {
        static void Main()
        {
            GradedCourse x = new GradedCourse("Test", 10.50m);
            Console.WriteLine(x.Passed());
            Console.ReadKey();
        }
    }
}