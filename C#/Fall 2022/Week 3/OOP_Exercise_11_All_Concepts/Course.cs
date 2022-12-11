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
        public Course (int courseid,string coursetitle)
        {
            this.CourseID = courseid;
            this.CourseTitle = coursetitle;
        }
        public int CourseID { get; set; }
        public string CourseTitle { get;}

        public Course(int courseid, decimal studentgrade)
        {
            this.CourseIDP = courseid;
            this.StudentGrade = studentgrade;
        }
        public int CourseIDP { get; set; }
        public decimal StudentGrade { get; set; }

    }
}
