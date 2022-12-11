using OOP_Exercise_11_All_Concepts;
using System;
using System.Numerics;
using System.Security.Principal;

namespace OOP_Exercise_11_All_Concepts
{
    class OOP_Exercise_11_All_Concepts
    {
        static void Main(string[] args)
        {
            

            List<Enrollment> enrollmentlist = new List<Enrollment>();
            List<Course> courses = new List<Course>();
            College CollegeList = new College(courses,enrollmentlist);

            //Data to make testing easier
            string firstname1 = "Jhames", firstname2 = "Moregan", firstname3 = "Phil", coursetitle = "Title";
            int intuserinput = 0, course1 = 12345, course2 = 98765, course3 = 65498, stuid1 = 10000, stuid2 = 10001, stuid3 = 10002;
            decimal gradeone = 0,gradetwo = 50 ,gradethree = 100;
            Course courseone = new Course(course1, coursetitle);
            Course coursetwo = new Course(course2, coursetitle);
            Course coursethree = new Course(course3, coursetitle);
            courses.Add(courseone);
            courses.Add(coursetwo);
            courses.Add(coursethree);

            Course coursegradeone = new Course(course1, gradeone);
            Course coursegradetwo = new Course(course2, gradetwo);
            Course coursegradethree = new Course(course3, gradethree);
            List<Course> coursesgradesone = new List<Course>();
            List<Course> coursesgradestwo = new List<Course>();
            List<Course> coursesgradesthree = new List<Course>();
            coursesgradesone.Add(coursegradeone);
            coursesgradesone.Add(coursegradetwo);
            coursesgradesone.Add(coursegradethree);
            coursesgradestwo.Add(coursegradeone);
            coursesgradestwo.Add(coursegradetwo);
            coursesgradestwo.Add(coursegradethree);
            coursesgradesthree.Add(coursegradeone);
            coursesgradesthree.Add(coursegradetwo);
            coursesgradesthree.Add(coursegradethree);

            Enrollment studentone = new Enrollment(stuid1, firstname1, firstname1, coursesgradesone);
            Enrollment studenttwo = new Enrollment(stuid2 , firstname2, firstname2, coursesgradestwo);
            Enrollment studentthree = new Enrollment(stuid3, firstname3, firstname3, coursesgradesthree);
            enrollmentlist.Add(studentone);
            enrollmentlist.Add (studenttwo);
            enrollmentlist.Add(studentthree);

            while (intuserinput != 7)
            {
                int stuid = 0, courseid = 0, grade = 0;
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
                    List<Course> list = new List<Course>();
                    CollegeList.EnterStudents(courseid, stuid, firstname, lastname, list, coursegrade);
                }
                else if (intuserinput == 3)
                {
                    CollegeList.OutputListCourses();
                    Console.WriteLine("Please select a course ID to input: ");
                    courseid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please select a course title to input: ");
                    title = Console.ReadLine();
                    CollegeList.ShowStuCourseIDandTitle(courseid, title);
                    Console.WriteLine("Which Student would you like to remove?");
                    stuid = int.Parse(Console.ReadLine());
                    CollegeList.RemoveStudent(stuid);
                    Console.ReadKey();
                }
                else if (intuserinput == 4)
                {
                    CollegeList.OutputListCourses();
                    Console.WriteLine("Please input a course you would like to remove");
                    courseid = int.Parse(Console.ReadLine());
                    CollegeList.RemoveCourse(courseid);                                       
                }
                else if (intuserinput == 5)
                {
                    CollegeList.OutputListCourses();
                    Console.WriteLine("Please input the course: ");
                    courseid = int.Parse(Console.ReadLine());
                    CollegeList.ShowStuCourseID(courseid);
                    Console.WriteLine("Please input the student ID you wish to update: ");
                    stuid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please input the student first name you wish to update: ");
                    string stufirstname = Console.ReadLine();
                    Console.WriteLine("Please input the student grade you wish to update: ");
                    decimal gradeinput = decimal.Parse(Console.ReadLine());
                    CollegeList.EnterStuGrade(stuid,stufirstname,courseid,gradeinput);

                    Console.ReadKey();
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