using System;

namespace CM2115_SmartHome.devices.Lc;

public interface ICopy
{
    void Copy(String text);
}

public class LaserCopy : ICopy//interface implementation
{
    public void Copy(string text)
    {
        Console.WriteLine("Copying: " + text + " on laser copier");
    }
}

