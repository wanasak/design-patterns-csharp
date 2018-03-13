using System;

namespace factory_method
{
    public class VoltMeter : IDevice
    {
        private Random r = null;
        public VoltMeter()
        {
            r = new Random();
        }
        public int Measure()
        {
            return r.Next(-230, 230);
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Turn on Volt Meter.");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Turn off Volt Meter.");
        }
    }
}
