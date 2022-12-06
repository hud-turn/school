using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    internal class Device_List
    {
        public Device_List(List <Device> devices)
        {
            this.Devices = devices;
        }
        public List <Device> Devices { get; set; }
        public double LongestUpDevice(double uptime)
        {
            uptime = 0;
            foreach (Device d in this.Devices)
            {
                if(d.Device_Uptime > 0)
                {
                    uptime = d.Device_Uptime;
                }
            }
            return uptime;
        }
        public void PowerConsumptMedian()
        {

        }
    }
}
