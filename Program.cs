

using System;
using CM2115_SmartHome.devices.Lp;
using CM2115_SmartHome.devices.Lc;
using CM2115_SmartHome.devices.Ls;
using CM2115_SmartHome.devices.Md;

namespace CM2115_SmartHome.devices;

public abstract class Device
{
 public string Status
 {
     get => _status;
 }
//Debugging prevents null
 

protected string _status;//extra debugger
public Device()
{
    this._status = "Unknown";//another debugger
}
}

public interface IPrint{ //declaring the interfaces
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

public interface IFax : IPrint, IScan//combining the interfaces
{
    void Fax(string text);
}
public class MultiFunctionDevice : ICopy, IScan, IFax//nested interfaces

{
    public void Copy(string text)//execute code behind the scenes 
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


public class LaserPrinter : Device, IPrint  //inherits from abtract class and interface
{
    public void Print(string text)
    {
        Console.WriteLine("Printing: " + text + " on laser printer");
    }
}



class Program
{
    static void Main(string[] args)
    {
        SendToPrinter(new LaserPrinter(), "Hello world"); //polymorphism
        SendToPrinter(new MultiFunctionDevice(), "Hello world");//polymorphism
    }

    static void SendToPrinter(IPrint printer, string text)//final step to printing
    {
        printer.Print(text);
    }
}
