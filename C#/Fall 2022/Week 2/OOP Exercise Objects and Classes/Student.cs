using OOP_Exercise_Objects_and_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_Objects_and_Classes
{
    internal class Student         
    {
        public Student(string firstname, string lastname, double grade)//don't do uppercase parameters also public allows the for that program to be global. This is a constructor
        {
            this.FirstName = firstname;//this passes firstname from our program.cs file over to 
            this.LastName = lastname;
            this.Grade = grade;
        }
        public string FirstName { get; set; }//get means I can read and set means I can change the value of that property
        public string LastName { get; set; }
        public double Grade { get; set; } //get means that I can read the value of that property and set means that I can change the value
    }
}