using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise10_Interfaces
{
    internal class Hotel
    {
        public Hotel(double floornum, double roomnum, double unix_time_check_in, double unix_time_check_out )
        {
            this.FloorNum = floornum;
            this.RoomNum = roomnum;
            this.UnixCheckIn = unix_time_check_in;
            this.UnixCheckOut = unix_time_check_out;
        }
        public double FloorNum { get; set; }
        public double RoomNum { get; set; }
        public double UnixCheckIn { get; set; }
        public double UnixCheckOut { get; set; }
    }
}
