using Microsoft.Extensions.Hosting;

namespace ManagedCode.TestsDetector.Extensions;

public static class TestDetectorExtensions
{
    public static bool IsTests(this IHostEnvironment hostEnvironment)
    {
        return TestDetector.IsInTest;
    }
}