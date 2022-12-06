using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    internal class Device
    {
        public Device(string device_name, int device_wattage, double device_uptime)
        {
            this.Device_Name = device_name;
            this.Device_Wattage = device_wattage;
            this.Device_Uptime = device_uptime;
        }
        public string Device_Name { get; set; }
        public int Device_Wattage { get; set; }
        public double Device_Uptime { get; set; }
    }
}
