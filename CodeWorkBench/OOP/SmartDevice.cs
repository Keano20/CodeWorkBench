namespace CodeWorkBench.OOP;

// The base Class
public abstract class SmartDevice
{
    public string DeviceName { get; set; }
    
    public void ConnectToWifi()
    {
        Console.WriteLine($"{DeviceName} is connecting to the home WiFi network...");
    }
    
    public abstract void ShowStatus();
}