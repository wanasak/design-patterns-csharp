namespace factory_method
{
    public enum Device
    {
        AM,
        VOLT,
        OHM
    }
    public class DeviceFactory
    {
        public static IDevice CreateDevice(Device device)
        {
            switch (device)
            {
                case Device.AM: return new AmMeter();
                case Device.VOLT: return new VoltMeter();
                case Device.OHM: return new OhmMeter();
                default: return new AmMeter();
            }
        }
    }
}
