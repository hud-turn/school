using Exercise_3;
using In_Class_Work;
using System;

namespace In_Class_Work
{
    class Program
    {
        static void Main()
        {
            string comp_i = "Composition I", mod_eng = "Modern English", comp_ii = "Composition II", old_eng="Old English";//declaring strings
            Console.WriteLine("An english degree has three courses which need to be passed in order to obtain a degree.\nThese courses are " + comp_i + ", " + mod_eng + ", " + comp_ii + ", and " + old_eng + ".");
            GradedCourse x = new GradedCourse(comp_i, 80);//running comp_i and a grade which is 80 through the graded course. Since this grade is more than 70 the user will pass. x = true now
            GradedCourse y = new GradedCourse(mod_eng, 30);//running mod_eng and a grade which is 30 through GradedCourse. Since this grade is less than 70 the user will not pass. y = false now
            PassFailCourse aa = new PassFailCourse(comp_ii, true); //running comp_ii through and telling the bool value that the user did indeed pass. aa = true now.
            PassFailCourse bb = new PassFailCourse(old_eng, true);// running old_eng through and telling the bool value that the user did indeed pass. bb = true now.

            //these lines below will show the output and result of the previous steps
            //Console.WriteLine("x" + x.Passed());
            //Console.WriteLine("y" + y.Passed());
            //Console.WriteLine("aa" + aa.Passed());
            //Console.WriteLine("bb" + bb.Passed());

            Degree d = new Degree(aa, bb, x, y);//we pass the variables from the previous section over to the Degree class and create a new variable with the datatype of Degree.
            Console.Write("\nHas the student passed three classes and obtained their degree? ");//output
            if (d.Passed() == true)//did the user pass the class? we run .Passed() on the varible d that we created.
            {
                Console.Write("Yes");
            }
            else//if the user didn't pass then they (by default) did not pass.
            {
                Console.Write("No");
            }
            Console.ReadKey();
        }
    }
}