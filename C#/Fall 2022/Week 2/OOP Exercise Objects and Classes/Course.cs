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
        public Course (string coursename, string courseid, List<Student> lststudent)// This is a constructor | Don't do uppercase parameters | Also public allows the for that program to be global
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
            foreach( Student s in LSTstudent)//this says "Hey for every datatype in this list
            {
                if (s.Grade < minimumgrade)
                {
                    minimumgrade = s.Grade;
                }
            }
            return minimumgrade;//returns grade minimum to GradeMin()
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
            return maxgrade;//returns grade maximum to GradeMax()
        }
        public double GradePercent(char parameter)//this is a method and it contains a parameter which is a char type
        {
            double gradepercenta = 0, gradepercentb = 0, gradepercentc = 0, gradepercentd = 0, gradepercentf = 0;//stores number of grades with a certain percentage
            char a = 'A', b = 'B',c = 'C', d = 'D', f = 'F';//used for char matching

            foreach (Student s in LSTstudent)
            {
                if (s.Grade >= 90)
                {
                    gradepercenta++;//adds 1 to gradepercenta
                }
                else if (s.Grade >= 80 && s.Grade <= 89)
                {
                    gradepercentb++;//adds 1 to gradepercentb
                }
                else if (s.Grade >= 70 && s.Grade <= 79)
                {
                    gradepercentc++;//adds 1 to gradepercentc
                }
                else if (s.Grade >= 60 && s.Grade <= 69)
                {
                    gradepercentd++;//adds 1 to gradepercentd
                }
                else
                {
                    gradepercentf++;//adds 1 to gradepercentf
                }
            }

            if (parameter == a)
            {
                return (gradepercenta/LSTstudent.Count())*100;//this returns the % of A's in the class
            }
            else if (parameter == b)
            {
                return (gradepercentb / LSTstudent.Count())*100;//this returns the % of B's in the class
            }
            else if (parameter == c)
            {
                return (gradepercentc / LSTstudent.Count())*100;//this returns the % of C's in the class
            }
            else if (parameter == d)
            {
                return (gradepercentd / LSTstudent.Count()) * 100;//this returns the % of D's in the class
            }
            else if (parameter == f)
            {
                return (gradepercentf / LSTstudent.Count()) * 100;//this returns the % of F's in the class
            }
            else
            {
                return 0;
            }

        }
    }
}
