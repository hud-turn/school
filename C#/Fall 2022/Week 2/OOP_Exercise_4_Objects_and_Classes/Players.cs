using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Class_Work
{
    internal class Players
    {
        public Players(string playerpos, string playername, int age)//don't do uppercase parameters also public allows the for that program to be global
        {
            this.PlayerPOS = playerpos;
            this.PlayerName = playername;
            this.Age = age;
        }
        public string PlayerPOS { get; set; }//get means I can read and set means I can change the value of that property
        public string PlayerName { get; set; }
        public int Age { get; set; } //get means that I can read the value of that property and set means that I can change the value
    }
}