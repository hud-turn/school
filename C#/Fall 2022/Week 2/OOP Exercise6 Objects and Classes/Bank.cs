using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise6_Objects_and_Classes
{
    internal class Bank
    {
        public Bank(List<Member> members)
        {
            this.Members = members;
        }
        public List<Member> Members { get; set; }
    }
    public List<Member> ListAllMembers()
    {
        foreach (s in List<Member>)
        {
            return Console.WriteLine(s.MemberName);
        }
    }
}
