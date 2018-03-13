using System;

namespace factory_method
{
    public class OhmMeter : IDevice
    {
        private Random r = null;
        public OhmMeter()
        {
            r = new Random();
        }
        public int Measure()
        {
            return r.Next(0, 1000000);
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Turn on Ohm Meter.");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Turn off Ohm Meter.");
        }
    }
}
