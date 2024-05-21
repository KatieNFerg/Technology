using System.Diagnostics.Contracts;
namespace Technology.test;

public class Smartphone : Computer
{
    public double Apps { get; set; }

    public Smartphone(double ram, double storage, bool hasKeyboard, int apps)
        : base(ram, storage, hasKeyboard)
    {
        Apps = apps;
    }

    public string TooManyApps()
    {
        if (Apps > 9)
        {
            return "You are running out of storage space!";
        }
        else
        {
            return "You have plenty of storage space left. Have you been to the App store?";
        }
    }
}
