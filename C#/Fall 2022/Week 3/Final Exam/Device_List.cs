using System;
using Final_Exam;


namespace Final_Exam
{
    internal class Device_List
    {
        public Device_List(List <DeviceH> devices)
        {
            this.Devices = devices;
        }
        public List <DeviceH> Devices { get; set; }

        public double LongestUpDevice()
        {
            double uptime = 0;
            foreach (DeviceH d in this.Devices)
            {
                if(d.Device_UptimeI > uptime)
                {
                    uptime = d.Device_UptimeI;
                }
            }
            return uptime;
        }
        public void PowerConsumptMedian()
        {
            int intmediani = 0, intmedianii = 0;
            double powerconsuptmedian = 0, doublemedian = 0, doubmediani = 0, doubleprocessedhigh = 0, doubmedianii = 0, count = 0, doubleuserprocessedlow = 0, doubhigher = 0, doublower = 0;
            List <int> ints = new List<int>();
            foreach (DeviceH c in this.Devices)
            {
                count++;
                ints.Add(c.Device_WattageI);
            }
            ints.Sort();
            //gets the length of the list so that we can check if the input is even or odd
            doublemedian = count % 2;
            if (doublemedian == 0)//if the input is a number ending without a decimal
            {
                doubleprocessedhigh = ((count - 1) / 2) + 0.1;//finding the higher number out of the two numbers used for the median
                doubmediani = Math.Round(doubleprocessedhigh, 0);//converting the median to an integer so we can process it easily in the next step

                doubleuserprocessedlow = (((count - 1) / 2) - 0.1);//finding the lower number out of the two numbers used for the median
                doubmedianii = Math.Round(doubleuserprocessedlow, 0);//converting the median to an integer so we can process it easily in the next step

                intmediani = Convert.ToInt32(doubmediani);//converting double to int
                intmedianii = Convert.ToInt32(doubmedianii);//converting double to int

                //Console.WriteLine("(" + intmediani + ")"); This line was used in the debugging of the program

                doubhigher = ints[intmediani];//median highernumber in integer form
                doublower = ints[intmedianii];//median lowernumber in integer form
                powerconsuptmedian = ((doubhigher + doublower)/2);//sum of the two numbers
                //Console.WriteLine("The median is: " + doublemediancalc / 2);
                //Console.WriteLine("if"); This line was used in the debugging of the program

            }
            else
            {
                intmediani = Convert.ToInt32(Math.Round((count - 1) / 2));
                powerconsuptmedian = ints[intmediani];
                //Console.WriteLine("else"); This line was used in the debugging of the program
            }
            Console.WriteLine(powerconsuptmedian);
        }
    }
}
