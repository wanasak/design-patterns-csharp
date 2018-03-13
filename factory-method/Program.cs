using System;

namespace factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            IDevice device = DeviceFactory.CreateDevice(Device.AM);
            device.TurnOn();
            System.Console.WriteLine(device.Measure()); 
            System.Console.WriteLine(device.Measure()); 
            System.Console.WriteLine(device.Measure()); 
            device.TurnOff();

            device = DeviceFactory.CreateDevice(Device.VOLT);
            device.TurnOn();
            System.Console.WriteLine(device.Measure()); 
            System.Console.WriteLine(device.Measure()); 
            System.Console.WriteLine(device.Measure()); 
            device.TurnOff();

            device = DeviceFactory.CreateDevice(Device.OHM);
            device.TurnOn();
            System.Console.WriteLine(device.Measure()); 
            System.Console.WriteLine(device.Measure()); 
            System.Console.WriteLine(device.Measure()); 
            device.TurnOff();
        }
    }
}
