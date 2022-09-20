using In_Class_Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_Objects_and_Classes
{
    internal class GetAverageGrade
    {
        public GetAverageGrade(decimal decgrade)
        {
            this.DecGrade = decgrade;
        }
        public decimal DecGrade { get; set; }
        public decimal ()
        {
            foreach (Student s in strnamelst)//iterating through every line in strnamelst
            {
                Console.WriteLine(s.FirstName + s.LastName + s.Grade);//printing the output
                doubgrade += s.Grade;
            }
        }
    }
}
