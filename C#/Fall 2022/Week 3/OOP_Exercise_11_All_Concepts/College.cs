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
            Console.WriteLine();
        }
        public void EnterStudents(int courseid, int stuid, string firstname, string lastname,List<Course> list, decimal grade)
        {

            Course newcourse = new Course(courseid, grade);
            list.Add(newcourse);
            Enrollment Enrolled = new Enrollment(stuid, firstname, lastname, list);
            Console.Clear();
            Console.WriteLine("The student's information has been entered into the system");
            Console.ReadLine();
        }
        public void ShowStuCourseIDandTitle(int courseid, string coursetitle)
        {
            List<Student> nlist1 = new List<Student>();
            Console.Clear();
            foreach (Enrollment c in this.EnrollmentList)
            {
               foreach (Course d in c.ListofCourses)
                {
                    if(d.CourseID == courseid && d.CourseTitle == coursetitle)
                    {
                        Console.WriteLine(c.StuID +" | "+ c.LastName +" "+ c.FirstName);
                    }
                }
            }
        }
        public void ShowStuCourseID(int courseid)
        {
            List<Student> nlist1 = new List<Student>();
            Console.Clear();
            foreach (Enrollment c in this.EnrollmentList)
            {
                foreach (Course d in c.ListofCourses)
                {
                    if (d.CourseID == courseid)
                    {
                        Console.WriteLine(c.StuID + " | " + c.LastName + " " + c.FirstName);
                    }
                }
            }
        }
        public void RemoveStudent(int stuid)
        {
            foreach(Enrollment c in this.EnrollmentList)
            {
                if(stuid == c.StuID)
                {
                    EnrollmentList.Remove(c);
                    Console.WriteLine("The student has successfully been removed");
                }
                else
                {
                    Console.WriteLine("The student was not successfully removed from the system");
                }
            }
        }
        public void RemoveCourse(int courseid)
        {
            foreach (Enrollment a in this.EnrollmentList)
            {
                foreach (Course d in a.ListofCourses)
                {
                    if (d.CourseID == courseid)
                    {
                        a.ListofCourses.Remove(d);
                    }
                }
            }
            foreach (Course c in this.CourseList)
            {
                if (courseid == c.CourseID)
                {
                    CourseList.Remove(c);
                    Console.WriteLine("The course has successfully been removed");
                }
                else
                {
                    Console.WriteLine("The course was not successfully removed from the system");
                }
            }
        }
        public void EnterStuGrade(int stuid,string firstname, int courseid, decimal stugrade)
        {
            foreach(Enrollment a in this.EnrollmentList)
            {
                foreach(Course d in a.ListofCourses)
                {
                    if(stuid == a.StuID && firstname == a.FirstName && courseid == d.CourseID)
                    {
                        d.StudentGrade = stugrade;
                    }
                    else
                    {
                        Console.WriteLine("The student couldn't be found.");
                    }
                }
            }
        }
    }
}