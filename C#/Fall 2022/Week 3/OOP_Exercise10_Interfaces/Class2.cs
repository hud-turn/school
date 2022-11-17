using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Exercise10_Interfaces
{
    class A
    {
        A(string name) { this.Name = name; }
        public string Name { get; set; }
        public virtual void PrintName() { Console.Writeline(“Your name is “ + this.Name); }
    }
    class B : A
    {
        B(string name) : base(name) { }
        public override void PrintName()
        {
            Console.Writeline(“B: Your name is “ + this.Name);
        }
    }
}
