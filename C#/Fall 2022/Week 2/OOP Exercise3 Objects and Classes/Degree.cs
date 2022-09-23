using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Degree
    {
        public Degree(PassFailCourse pfcoursea, PassFailCourse pfcourseb, GradedCourse gcoursea, GradedCourse gcourseb)//this is a constructor
        {
            this.PFCourseA = pfcoursea;
            this.PFCourseB = pfcourseb;
            this.GCourseA = gcoursea;
            this.GCourseB = gcourseb;
        }
        public PassFailCourse PFCourseA { get; set; }
        public PassFailCourse PFCourseB { get; set; }
        public GradedCourse GCourseA { get; set; }
        public GradedCourse GCourseB { get; set; }

        public bool Passed()//this is a method
        {
            int iterator = 0;
            if (PFCourseA.Passed() == true)
            {
                iterator++;
            }
            if (PFCourseB.Passed() == true)
            {
                iterator++;
            }
            if (GCourseA.Passed() == true)
            {
                iterator++;
            }
            if (GCourseB.Passed() == true)
            {
                iterator++;
            }
            if (iterator >= 3 )
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
