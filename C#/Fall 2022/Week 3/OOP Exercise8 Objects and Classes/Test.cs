using System;

public class Class1
{
    public class A
    {
        public A(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
    public class B : A
    {
        public B(string name) : base(name)
        {
            //code
        }
    }
    class Program
    {
        static void Main()
        {
            B myObject = new B("Moe");
            myObject.Name = "Joe";
        }
    }
}
