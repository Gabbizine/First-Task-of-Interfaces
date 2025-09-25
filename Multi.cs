using System;
using CM2115_SmartHome.devices.Lp;
using CM2115_SmartHome.devices.Lc;
using CM2115_SmartHome.devices.Ls;
using CM2115_SmartHome.devices;


namespace CM2115_SmartHome.devices.Md;

public abstract class Device
{
    public string Status
    {
        get => status;
    }

    protected string status;
    public Device()
    {
        this.status = "Unknown";
    }
}

public class FaxMachine : Device, IFax, IPrint
{
    public void Print(string text)
    {
        Console.WriteLine("Printing: " + text + " on fax machine");
    }

    public void Scan(string text)
    {
        Console.WriteLine("Scanning: " + text + " on fax machine");
    }

    public void Fax(string text)
    {
        Console.WriteLine("Faxing: " + text + " on fax machine");
    }
}

public interface IPrint{// interfaces have to be stated among class files whether in the main program or not
//this ensures the connection is made
    void Print(String text);
}

public interface ICopy
{
    void Copy(String text);
}

public interface IScan
{
    void Scan(String text);
}

public interface IFax : IPrint, IScan
{
    void Fax(string text);
}


public class MultiFunctionDevice : ICopy, IScan, IFax//declaring the class outside of the main program
{
    public void Copy(string text)
    {
        Console.WriteLine("Copying:" + text + " on multi-function device");
    }
    public void Scan(string text)
    {
        Console.WriteLine("Scanning:" + text + " on multi-function device");
    }
    public void Print(string text)
    {
        Console.WriteLine("Printing:" + text + " on multi-function device");
    }
    public void Fax(string text)
    {
        Console.WriteLine("Faxing: " + text + " on multi-function device");
    }
}