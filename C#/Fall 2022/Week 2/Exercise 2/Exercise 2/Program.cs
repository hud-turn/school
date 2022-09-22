using Exercise_3;
using In_Class_Work;
using System;
using System.Security.Cryptography.X509Certificates;

namespace In_Class_Work
{
    class Program
    {
        static void Main()
        {
            
            GradedCourse x = new GradedCourse("Test", 80);
            GradedCourse y = new GradedCourse("English", 30);
            PassFailCourse cc = new PassFailCourse("Composition", true);
            PassFailCourse dd = new PassFailCourse("Old English", false);

            //Console.WriteLine(y.Passed());

            Degree d = new Degree(cc, dd, x, y);
            Console.WriteLine(d.Passed());
            Console.ReadKey();
        }
    }
}