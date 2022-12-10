using System;
using OOP_Exercise_11_All_Concepts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_11_All_Concepts
{
    internal class Student
    {
        public Student (int stuid, string firstname, string lastname)
        {
            this.StuID = stuid;
            this.FirstName = firstname;
            this.LastName = lastname;
        }
        public int StuID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
