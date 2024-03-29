﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class GradedCourse//this creates the class, access specifier is internal in this case
    {
        //we have
        //constructors
        //properties
        //and methods
        public GradedCourse(string gccoursename, decimal gcgrade)//we use a constructor here, public is the access specifier for the class. The properties are listed in the ()
        {
            this.GCCourseName = gccoursename;
            this.GCGrade = gcgrade;
        }
        public string GCCourseName { get; set; }//these are the access specifier for the variables in the class, this allows us to read and write
        public decimal GCGrade { get; set; }//these are the access specifier for the variables in the class, this allows us to read and write
        public bool Passed()//this is a method
        {
            if(GCGrade >= 70)
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
