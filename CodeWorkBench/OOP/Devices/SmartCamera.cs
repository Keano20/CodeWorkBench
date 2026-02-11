namespace CodeWorkBench.OOP.Devices;

public class SmartCamera : SmartDevice, IPowerable, IMotionDetection
{
    public void TurnOn() => Console.WriteLine($"{DeviceName} is booting up...");
    public void TurnOff() => Console.WriteLine($"{DeviceName} is shutting down.");

    public override void ShowStatus()
    {
        Console.WriteLine($"{DeviceName} is active and monitoring for security threats.");
    }

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