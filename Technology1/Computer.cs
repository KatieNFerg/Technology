using System.Diagnostics.Contracts;
namespace Technology.test;
public class Computer
{
    public double Ram {get;set;}
    public double Storage {get;set;}
    public readonly bool hasKeyboard;
    public Computer(double ram, double storage, bool hasKeyboard)
    {
        Ram = ram;
        Storage = storage;
        this.hasKeyboard = hasKeyboard;
    }
    public double IncreaseRam(double extraRam)
    {
        return Ram += extraRam;
    }
    public double IncreaseStorage(double extraStorage)
    {
        return Storage += extraStorage;
    }
}
  
