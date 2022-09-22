using OOP_Exercise_Objects_and_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_Objects_and_Classes
{
    internal class Course
    {
        public Course (string coursename, string courseid, List<Student> lststudent)//don't do uppercase parameters also public allows the for that program to be global
        {
            this.CourseName = coursename;//this passes firstname from our program.cs file over to 
            this.CourseID = courseid;
            this.LSTstudent = lststudent;
        }
        public string CourseName { get; set; }//get means I can read and set means I can change the value of that property
        public string CourseID { get; set; }
        public List<Student> LSTstudent { get; set; } //get means that I can read the value of that property and set means that I can change the value
        public double GradeAverage()//this is a method
        {
            double averagegrd = 0, doubgrade = 0;

            foreach ( Student s in LSTstudent)//iterating through every line in strnamelst
            {
                //Console.WriteLine(s.FirstName + s.LastName + s.Grade);//printing the output
                doubgrade += s.Grade;
            }
            averagegrd = doubgrade/LSTstudent.Count();
            return averagegrd;
        }
        public double GradeMin()//this is a method
        {
            double minimumgrade = double.MaxValue;
            foreach( Student s in LSTstudent)
            {
                if (s.Grade < minimumgrade)
                {
                    minimumgrade = s.Grade;
                }
            }
            return minimumgrade;
        }
        public double GradeMax()//this is a method
        {
            double maxgrade = double.MinValue;
            foreach (Student s in LSTstudent)
            {
                if (s.Grade > maxgrade)
                {
                    maxgrade = s.Grade;
                }
            }
            return maxgrade;
        }
        public double GradePercent()
        {
            double gradepercenta = 0, gradepercentb = 0, gradepercentc = 0, gradepercentd = 0, gradepercentf = 0;


            return gradepercenta;
        }
    }
}
