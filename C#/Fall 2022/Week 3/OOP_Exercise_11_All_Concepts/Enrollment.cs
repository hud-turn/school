using System;
using OOP_Exercise_11_All_Concepts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_11_All_Concepts
{
    internal class Enrollment : Student
    {
        public Enrollment (int stuid, string firstname, string lastname,int courseid, int grade):base(stuid, firstname, lastname)
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
