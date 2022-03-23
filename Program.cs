using System;
using tpertemuan3;

namespace taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek taxi
            Taxi taxi = new Taxi();

            // penentuan nilai properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DroppOffPassenger();

            Console.ReadKey();
        }
    }
}