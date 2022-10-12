using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
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
    public List<string> ListAllMembers(List<Member> memberlist)
    {
        List<string> membernamelst = new List<string>();
        foreach (Member s in memberlist)
        {
            membernamelst.Add(s.MemberName);
        }
        return membernamelst;
    }

}
