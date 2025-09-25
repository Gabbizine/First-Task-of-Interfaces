
using System;

namespace CM2115_SmartHome.devices.Lp;
public interface IPrint
{
    void Print(string text);
}

public class LaserPrinter : IPrint //interface implementation
{
    public void Print(string text)
    {
        Console.WriteLine("Printing: " + text + " on laser printer");
    }
}
