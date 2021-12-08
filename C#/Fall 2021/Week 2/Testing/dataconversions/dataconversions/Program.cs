using System;

namespace dataconversions
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "52.5";
            //You need to make sure that your data types are correct, you can't use int on this variable
            decimal age = decimal.Parse(data);
            Console.WriteLine(age);
            Console.ReadKey();
        }
    }
}
