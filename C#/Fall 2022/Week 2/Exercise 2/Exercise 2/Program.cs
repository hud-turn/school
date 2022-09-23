﻿using Exercise_3;
using In_Class_Work;
using System;

namespace In_Class_Work
{
    class Program
    {
        static void Main()
        {
            string comp_i = "Composition I", mod_eng = "Modern English", comp_ii = "Composition II", old_eng="Old English";
            Console.WriteLine("An english degree has three courses which need to be passed in order to obtain a degree.\nThese courses are " + comp_i + ", " + mod_eng + ", " + comp_ii + ", and " + old_eng + ".");
            GradedCourse x = new GradedCourse(comp_i, 80);//running comp_i and a grade which is 80 through the graded course. If the grade passes then x will be true
            GradedCourse y = new GradedCourse(mod_eng, 30);
            PassFailCourse aa = new PassFailCourse(comp_ii, true);
            PassFailCourse bb = new PassFailCourse(old_eng, true);

            //Console.WriteLine("x" + x.Passed());
            //Console.WriteLine("y" + y.Passed());
            //Console.WriteLine("aa" + aa.Passed());
            //Console.WriteLine("bb" + bb.Passed());

            Degree d = new Degree(aa, bb, x, y);
            Console.Write("\nHas the student passed three classes and obtained their degree? ");
            if (d.Passed() == true)
            {
                Console.Write("Yes");
            }
            else
            {
                Console.Write("No");
            }
            Console.ReadKey();
        }
    }
}