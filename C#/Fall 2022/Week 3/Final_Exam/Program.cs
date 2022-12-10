using System;
using Final_Exam;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Security.Principal;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    class Program
    {
        static void Main()
        {
            List<DeviceH> devices = new List<DeviceH>();
            Device_List ListOne = new Device_List(devices);       
            DeviceH Device1 = new DeviceH("Device1", 10, 100);
            DeviceH Device2 = new DeviceH("Device2", 20, 200);
            DeviceH Device3 = new DeviceH("Device3", 30, 300);
            DeviceH Device4 = new DeviceH("Device4", 40, 400);
            DeviceH Device5 = new DeviceH("Device5", 50, 500);
            DeviceH Device6 = new DeviceH("Device6", 60, 600);
            DeviceH Device7 = new DeviceH("Device7", 70, 700);
            DeviceH Device8 = new DeviceH("Device8", 80, 800);
            DeviceH Device9 = new DeviceH("Device9", 90, 900);
            DeviceH Device10 = new DeviceH("Device10", 100, 1000);

            devices.Add(Device1);
            devices.Add(Device2);
            devices.Add(Device3);
            devices.Add(Device4);
            devices.Add(Device5);
            devices.Add(Device6);
            devices.Add(Device7);
            devices.Add(Device8);
            devices.Add(Device9);
            devices.Add(Device10);

            Console.WriteLine("This is the device that has been up the longest: " + ListOne.LongestUpDevice());
            Console.WriteLine("This median power consumption is:");
            ListOne.PowerConsumptMedian();

        }
    }
}