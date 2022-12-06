using Final;
using Final_Exam;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Security.Principal;

namespace Final
{
    class Program
    {
        static void Main()
        {
            List<DeviceI> devices = new List<DeviceI>();
            Device_List ListOne = new Device_List(devices);
            Device Device1 = new DeviceI("Device1", 10, 100);
            Device Device2 = new DeviceI("Device2", 20, 200);
            Device Device3 = new DeviceI("Device3", 30, 300);
            Device Device4 = new DeviceI("Device4", 40, 400);
            Device Device5 = new DeviceI("Device5", 50, 500);
            devices.Add(devices);
        }
    }
}