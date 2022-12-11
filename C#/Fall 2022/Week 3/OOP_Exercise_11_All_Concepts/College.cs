using System;
using OOP_Exercise_11_All_Concepts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_11_All_Concepts
{
    internal class College
    {
        public College (List<Course> courselist,List<Enrollment> enrollmentlist)
        {
            this.CourseList = courselist;
            this.EnrollmentList = enrollmentlist;
        }
        public List<Course> CourseList { get; set; }
        public List <Enrollment> EnrollmentList { get; set; }
        public void OutputListCourses()
        {
            Console.WriteLine("ID   | Title");
            foreach(Course c in CourseList)
            {
                Console.WriteLine(c.CourseID + "|" + c.CourseTitle);
            }
        }
        public void EnterStudents(int courseid, int stuid, string firstname, string lastname,List<Course> list, decimal grade)
        {

            Course newcourse = new Course(courseid, grade);
            list.Add(newcourse);
            Enrollment Enrolled = new Enrollment(stuid, firstname, lastname, list);
            Console.Clear();
            Console.WriteLine("The student's has been entered into the system");
            Console.ReadLine();
        }
    }
}