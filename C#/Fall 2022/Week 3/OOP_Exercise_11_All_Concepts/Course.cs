using System;
using OOP_Exercise_11_All_Concepts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_11_All_Concepts
{
    internal class Course
    {
        public Course (int courseid,string coursetitle)//Polymorphism
        {
            this.CourseID = courseid;
            this.CourseTitle = coursetitle;
        }
        public int CourseID { get;}//encapsulation
        public string CourseTitle { get;}

        public Course(int courseid, decimal studentgrade)//Polymorphism
        {
            this.CourseIDP = courseid;
            this.StudentGrade = studentgrade;
        }
        public int CourseIDP { get;}//encapsulation
        public decimal StudentGrade { get; set; }

    }
}
