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
            Console.WriteLine("ID    | Name");
            foreach (Enrollment c in this.EnrollmentList)
            {
               foreach (Course d in c.ListofCourses)
                {
                    if(d.CourseIDP == courseid)
                    {
                        Console.WriteLine(c.StuID +" | "+ c.LastName +" "+ c.FirstName);
                    }
                }
            }
        }
        public void ShowStuCourseID(int courseid)
        {
            List<Student> nlist1 = new List<Student>();
            //Console.Clear();
            Console.WriteLine("ID    | Name");
            foreach (Enrollment c in this.EnrollmentList)
            {
                foreach (Course d in c.ListofCourses)
                {
                    if (d.CourseIDP == courseid)
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
                    if (d.CourseIDP == courseid)
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
            if (stugrade >=0 && stugrade <= 100)
            {
                foreach (Enrollment a in this.EnrollmentList)
                {
                    foreach (Course d in a.ListofCourses)
                    {
                        if (stuid == a.StuID && firstname == a.FirstName && courseid == d.CourseIDP)
                        {
                            d.StudentGrade = stugrade;
                            Console.WriteLine("The student was updated.");
                        }
                        else
                        {
                            //Console.WriteLine("The student couldn't be found.");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Please input a valid grade");
            }
        }
        public decimal GradeAvg()
        {
            int count = 0;
            decimal sum = 0, average = 0;
            foreach (Enrollment a in this.EnrollmentList)
            {
                foreach (Course d in a.ListofCourses)
                {
                    sum += d.StudentGrade;
                    count++;
                }
            }
            average = sum / count;
            return average;
        }
        public decimal MinGrade()
        {
            decimal mingrade = decimal.MaxValue;
            foreach (Enrollment a in this.EnrollmentList)
            {
                foreach (Course d in a.ListofCourses)
                {
                    if (d.StudentGrade <= mingrade)
                    {
                        mingrade = d.StudentGrade;
                    }
                }
            }
            return mingrade;
        }
        public decimal MaxGrade()
        {
            decimal maxgrade = decimal.MinValue;
            foreach (Enrollment a in this.EnrollmentList)
            {
                foreach (Course d in a.ListofCourses)
                {
                    if (d.StudentGrade >= maxgrade)
                    {
                        maxgrade = d.StudentGrade;
                    }
                }
            }
            return maxgrade;
        }
        public void DisplayGrades()
        {
            double count = 0, outputa = 0, outputb = 0, outputc = 0, outputd = 0, outputf = 0, aa = 0, bb = 0, cc = 0, dd = 0, ff = 0;
            foreach (Enrollment a in this.EnrollmentList)
            {
                foreach (Course d in a.ListofCourses)
                {
                    if (d.StudentGrade >= 90)
                    {
                        aa++;
                    }
                    else if(d.StudentGrade <90 && d.StudentGrade >= 80)
                    {
                        bb++;
                    }
                    else if (d.StudentGrade < 80 && d.StudentGrade >= 70)
                    {
                        cc++;
                    }
                    else if (d.StudentGrade < 70 && d.StudentGrade >= 60)
                    {
                        dd++;
                    }
                    else
                    {
                        ff++;
                    }
                }
            }
            count = aa + bb + cc + dd + ff;
            Console.WriteLine(Math.Round(((aa / count) * 100), 2) + "% of the class has an A");
            Console.WriteLine(Math.Round(((bb / count) * 100), 2) + "% of the class has a B");
            Console.WriteLine(Math.Round(((cc / count) * 100), 2) + "% of the class has a C");
            Console.WriteLine(Math.Round(((dd / count) * 100), 2) + "% of the class has a D");
            Console.WriteLine(Math.Round(((ff / count) * 100), 2) + "% of the class has a F");
        }
    }
}