using ManagedCode.EnvironmentDetector;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace ManagedCode.TestsDetector.NUnit;

[TestFixture]
public class Tests
{
    [Test]
    public void TestDetectorTest()
    {
        ClassicAssert.IsTrue(TestDetector.IsInTest);
    }
    
    [Test]
    public void MSTestDetectorTest()
    {
        ClassicAssert.IsFalse(MSTestDetector.IsInTest);
    }

    [Test]
    public void NUnitDetectorTest()
    {
        ClassicAssert.IsTrue(NUnitDetector.IsInTest);
    }

    [Test]
    public void XUnitDetectorTest()
    {
        ClassicAssert.IsFalse(XUnitDetector.IsInTest);
    }
}