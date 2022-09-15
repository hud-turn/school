using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Degree
    {
        public Degree(PassFailCourse pfcoursea, PassFailCourse pfcourseb, GradedCourse gcoursea, GradedCourse gcourseb)//this is a constructor
        {
            this.PFCourseA = pfcoursea;
            this.PFCourseB = pfcourseb;
            
        }
        public PassFailCourse PFCourseA { get; set; }
        public PassFailCourse PFCourseB { get; set; }

        public bool Passed()//this is a method
        {
            if (PFCourseA.Passed() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
