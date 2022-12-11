using OOP_Exercise_11_All_Concepts;
using System;
using System.Security.Principal;

namespace OOP_Exercise_11_All_Concepts
{
    class OOP_Exercise_11_All_Concepts
    {
        static void Main(string[] args)
        {
            int intuserinput = 0;
            List<Enrollment> enrollmentlist = new List<Enrollment>();
            List<Course> courses = new List<Course>();
            College CollegeList = new College(courses,enrollmentlist);
            while (intuserinput != 7)
            {
                int stuid = 0, courseid = 0,grade = 0;
                string title = "", firstname = "", lastname = "";
                Console.WriteLine("Welcome to the main menu!\nPlease input what function you would like to perform:\n1.Enter Course\n2.Enter Students\n3.Remove Students\n4.Remove Course\n5.Enter Student Grade\n6.Grade Analytics");
                intuserinput = int.Parse(Console.ReadLine());
                Console.Clear();
                if (intuserinput == 1)
                {
                    Console.WriteLine("Please add a course ID that has 5 characters:");
                    courseid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please add a course title:");
                    title = Console.ReadLine();
                    Course courseinput = new Course(courseid, title);
                    courses.Add(courseinput);
                }
                else if (intuserinput == 2)
                {
                    decimal coursegrade = -1;
                    Console.WriteLine("The output below is a list of courses that students can be enrolled in. Please select one.");
                    CollegeList.OutputListCourses();
                    Console.WriteLine("\nPlease input the course ID you want to select: ");
                    courseid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please input the student's ID: ");
                    stuid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please input the student's first name: ");
                    firstname = Console.ReadLine();
                    Console.WriteLine("Please input the student's last name: ");
                    lastname = Console.ReadLine();
                    CollegeList.EnterStudents(courseid, stuid, firstname, lastname, coursegrade);
                    List<Course> studentcourselst = new List<Course>();
                    Enrollment Enrolled = new Enrollment(stuid, firstname, lastname, studentcourselst);
                }
                else if (intuserinput == 3)
                {

                }
                else if (intuserinput == 4)
                {

                }
                else if (intuserinput == 5)
                {

                }
                else if (intuserinput == 6)
                {

                }
                else
                {

                }
                Console.Clear();//clearing terminal
            }
        }
    }
}