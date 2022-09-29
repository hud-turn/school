using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Degree
    {
        public Degree(PassFailCourse pfcoursea, PassFailCourse pfcourseb, GradedCourse gcoursea, GradedCourse gcourseb)//this is a constructor, this contains the properties
        {
            this.PFCourseA = pfcoursea;//we link the properties to the read access modifier listed down below
            this.PFCourseB = pfcourseb;
            this.GCourseA = gcoursea;
            this.GCourseB = gcourseb;
        }
        public PassFailCourse PFCourseA { get; set; }//these are the access specifier for the variables in the class, this allows us to read and write
        public PassFailCourse PFCourseB { get; set; }//these are the access specifier for the variables in the class, this allows us to read and write
        public GradedCourse GCourseA { get; set; }//these are the access specifier for the variables in the class, this allows us to read and write
        public GradedCourse GCourseB { get; set; }//these are the access specifier for the variables in the class, this allows us to read and write

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
                return true;//if iterator is greater than or equal to 3 then the .Passed method in this program will return true.
            }
            else
            {
                return false;//if the iterator is less than 3 then the .Passed method in this program will return false.
            }
        }
        

    }
}
