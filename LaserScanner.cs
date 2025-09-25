
using System;

namespace CM2115_SmartHome.devices.Ls;

public class LaserScanner : IScan
{
    public void Scan(string text)
    {
        Console.WriteLine("Scanning: " + text + " on laser scanner");
    }
}
