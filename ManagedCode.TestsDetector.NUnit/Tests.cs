using ManagedCode.EnvironmentDetector;
using NUnit.Framework;

namespace ManagedCode.TestsDetector.NUnit;

[TestFixture]
public class Tests
{
    [Test]
    public void TestDetectorTest()
    {
        Assert.IsTrue(TestDetector.IsInTest);
    }
    
    [Test]
    public void MSTestDetectorTest()
    {
        Assert.IsFalse(MSTestDetector.IsInTest);
    }

    [Test]
    public void NUnitDetectorTest()
    {
        Assert.IsTrue(NUnitDetector.IsInTest);
    }

    [Test]
    public void XUnitDetectorTest()
    {
        Assert.IsFalse(XUnitDetector.IsInTest);
    }
}