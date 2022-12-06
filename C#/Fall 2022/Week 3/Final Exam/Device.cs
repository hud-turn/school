using System;
using Final_Exam;


namespace Final_Exam
{
    public class Device
    {
        public Device(string device_name, int device_wattage)
        {
            this.Device_Name = device_name;
            this.Device_Wattage = device_wattage;
        }
        public string Device_Name { get; }
        public int Device_Wattage { get; set; }
    }
    public class DeviceH : Device
    {
        public DeviceH(string device_name, int device_wattage, double device_uptime) :base(device_name, device_wattage)
        {
            this.Device_NameI = device_name;
            this.Device_WattageI = device_wattage;
            this.Device_UptimeI = device_uptime;
        }
        public string Device_NameI { get; }
        public int Device_WattageI { get; set; }
        public double Device_UptimeI { get; set; }
    }
}
