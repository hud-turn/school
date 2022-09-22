using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class PassFailCourse//this creates the class
    {
        public PassFailCourse(string pfcoursename, bool pfgrade)//we use a constructor here, public is the access specifier. The properties are listed in the ()
        {
            this.PFCourseName = pfcoursename;
            this.PFGrade = pfgrade;
        }
        public string PFCourseName { get; set; }//these are the properties, this allows us to read and write
        public bool PFGrade { get; set; }//these are the properties, this allows us to read and write

        public bool Passed()//this is a method
        {
            return this.PFGrade;
        }
    }
}
