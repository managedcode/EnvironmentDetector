using ManagedCode.EnvironmentDetector;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ManagedCode.TestsDetector.MSTest;

[TestClass]
public class Tests
{
    [TestMethod]
    public void TestDetectorTest()
    {
        Assert.IsTrue(TestDetector.IsInTest);
    }
    
    [TestMethod]
    public void MSTestDetectorTest()
    {
        Assert.IsTrue(MSTestDetector.IsInTest);
    }

    [TestMethod]
    public void NUnitDetectorTest()
    {
        Assert.IsFalse(NUnitDetector.IsInTest);
    }

    [TestMethod]
    public void XUnitDetectorTest()
    {
        Assert.IsFalse(XUnitDetector.IsInTest);
    }
    
    [TestMethod]
    public void KubernetesDetectorTest()
    {
        Assert.IsFalse(KubernetesDetector.IsInKubernetes);
    }
    
    [TestMethod]
    public void DaprDetectorTest()
    {
        Assert.IsFalse(DaprDetector.IsInDapr);
    }
}