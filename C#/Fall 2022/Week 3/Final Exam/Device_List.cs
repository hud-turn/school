using System;
using Final;
using Final_Exam;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    internal class Device_List
    {
        public Device_List(List <DeviceI> devices)
        {
            this.Devices = devices;
        }
        public List <DeviceI> Devices { get; set; }

        public double LongestUpDevice(double uptime)
        {
            uptime = 0;
            foreach (DeviceI d in this.Devices)
            {
                if(d.Device_Uptime > uptime)
                {
                    uptime = d.Device_Uptime;
                }
            }
            return uptime;
        }
        public double PowerConsumptMedian(double powerconsuptmedian)
        {
            int count = 0;
            List <int> ints = new List<int>();
            foreach (DeviceI c in this.Devices)
            {
                count++;
                ints.Add(c.Device_Wattage);
            }
            ints.Sort();
            return powerconsuptmedian;
        }
    }
}
