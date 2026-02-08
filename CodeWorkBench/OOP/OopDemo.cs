using CodeWorkBench.OOP;
using CodeWorkBench.OOP.Devices;

public static class OopDemo
{
    public static void Run()
    {
        // A list of the abstract type holding different concrete types
        List<SmartDevice> devices = new List<SmartDevice>
        {
            new SmartSpeaker { DeviceName = "Sony Smart Speaker" },
        };

        Console.WriteLine("\n--- Smart Home Sync ---");
        foreach (var device in devices)
        {
            if (device is IPowerable power) power.TurnOn();
            
            device.ConnectToWifi(); // Shared logic
            device.ShowStatus();   // Overridden logic

            if (device is IVolume volume)
            {
                volume.VolumeUp();
                volume.VolumeDown();
                volume.Mute();
            }
            
            if (device is IPowerable powerD) powerD.TurnOff();
            
            Console.WriteLine("-----------------------");
        }
    }
}