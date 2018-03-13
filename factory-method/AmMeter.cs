using System;

namespace factory_method
{
    public class AmMeter : IDevice
    {
        private Random r = null;
        public AmMeter()
        {
            r = new Random();
        }
        public int Measure()
        {
            return r.Next(-25, 60);
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Turn on Am Meter.");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Turn off Am Meter.");
        }
    }
}
