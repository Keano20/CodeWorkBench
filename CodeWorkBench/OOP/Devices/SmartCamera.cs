namespace CodeWorkBench.OOP.Devices;

public class SmartCamera : SmartDevice, IPowerable, IMotionDetection
{
    // Implementation for IPowerable
    public void TurnOn() => Console.WriteLine($"{DeviceName} is booting up...");
    public void TurnOff() => Console.WriteLine($"{DeviceName} is shutting down.");

    // Implementation for the Abstract method in SmartDevice
    public override void ShowStatus()
    {
        Console.WriteLine($"{DeviceName} is active and monitoring for security threats.");
    }

    // Implementation for IMotionDetection
    public void ThreatDetected()
    {
        Console.WriteLine($"{DeviceName} has detected movement in the area! Please remain indoors and ensure all doors and windows are locked!");
    }

    public void NoThreatsDetected()
    {
        Console.WriteLine("No threats have been detected.");
    }

    public void NightVisionMode()
    {
        Console.WriteLine("Night vision is currently active");
    }
}