namespace CodeWorkBench.OOP.Devices;

public class SmartTv :SmartDevice, IPowerable, IVolume, IMovie
{
    // Implementation for IPowerable
    public void TurnOn() => Console.WriteLine($"{DeviceName} Is now powering on, please wait...");
    public void TurnOff() => Console.WriteLine($"{DeviceName} Is now turning off...");

    // Implementation for IVolume
    public void Mute() => Console.WriteLine("The TV is now muted, press again to un-mute.");
    public void VolumeDown() => Console.WriteLine("The volume has been set to 3");
    public void VolumeUp() => Console.WriteLine($"The volume has been set to 20");
    
    //Implementation for IMovie
    public void Pause() => Console.WriteLine("The film has been paused, press again when you would like to resume");
    public void FastForward() => Console.WriteLine("Fast forwarding 10 seconds at a time...");
    public void Rewind() => Console.WriteLine("Rewinding 10 seconds at a time...");
    public void ScreenRecord() => Console.WriteLine("Screen recording will begin in 3, 2, 1");

    // Implementation for the Abstract method in my smart device class
    public override void ShowStatus() => Console.WriteLine($"{DeviceName} Is now online and ready to stream films and TV shows");
}