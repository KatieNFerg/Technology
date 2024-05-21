using System.Runtime.CompilerServices;

namespace Technology.test;

[TestClass]
public class TechnologyTest
{
    [TestMethod]
    public void TestIncreasingRam()
    {
        Computer testingComputer = new Computer(2, 3, true);
        testingComputer.IncreaseRam(3);
        Assert.AreEqual(2, testingComputer.Ram);
        Assert.AreEqual(5, testingComputer.Ram);
    }
    [TestMethod]
    public void TestTooMuchWeight()
    {
        Laptop testingLaptop = new Laptop(6.0, true);
        testingLaptop.IsClunky();
        Assert.IsTrue(Laptop.Weight);
    }
}