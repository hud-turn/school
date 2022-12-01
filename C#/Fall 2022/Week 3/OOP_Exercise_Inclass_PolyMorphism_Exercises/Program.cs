using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace OOP_Exercise_Inclass_PolyMorphism_Exercises
{
    class Program
    {
        static void Main()
        {
            Account account = new Account(100, 7);
            Console.WriteLine((account.PrintName()));
        }
    }
}
