namespace CodeWorkBench.OOP.Devices;

// Inheritance comes FIRST, then Interfaces separated by commas
public class SmartSpeaker : SmartDevice, IPowerable, IVolume
{
    // Implementation for IPowerable
    public void TurnOn() => Console.WriteLine($"{DeviceName} is booting up...");
    public void TurnOff() => Console.WriteLine($"{DeviceName} is shutting down.");

    // Implementation for IVolume
    public void VolumeUp() => Console.WriteLine("Volume is now 11.");
    public void VolumeDown() => Console.WriteLine("Volume is now 10.");
    public void Mute() => Console.WriteLine("Speaker muted.");

    // Implementation for the Abstract method in SmartDevice
    public override void ShowStatus()
    {
        Console.WriteLine($"{DeviceName} is online and playing 'Lo-fi Beats'.");
    }
}