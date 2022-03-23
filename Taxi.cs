﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpertemuan3
{
    internal class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            string duty;

            if (OnDuty)
            {
                duty = "Yes";
            }
            else
            {
                duty = "No";
            }

            Console.WriteLine("Driver Name: {0}", DriverName);
            Console.WriteLine("On Duty: {0}", duty);
            Console.WriteLine("Number of Passenger: {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }

        public void DroppOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }

    }
}
