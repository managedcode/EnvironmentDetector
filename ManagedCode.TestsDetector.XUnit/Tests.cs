using ManagedCode.EnvironmentDetector;
using Xunit;

namespace ManagedCode.TestsDetector.XUnit;

public class Tests
{
    [Fact]
    public void TestDetectorTest()
    {
        Assert.True(TestDetector.IsInTest);
    }
    
    [Fact]
    public void MSTestDetectorTest()
    {
        Assert.False(MSTestDetector.IsInTest);
    }

    [Fact]
    public void NUnitDetectorTest()
    {
        Assert.False(NUnitDetector.IsInTest);
    }

    [Fact]
    public void XUnitDetectorTest()
    {
        Assert.True(XUnitDetector.IsInTest);
    }
}