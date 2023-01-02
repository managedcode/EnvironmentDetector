using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ManagedCode.EnvironmentDetector.Extensions;

public static class TestDetectorExtensions
{
    public static bool IsTests(this IHostEnvironment hostEnvironment)
    {
        return TestDetector.IsInTest;
    }
    
    public static bool IsTests(this IServiceCollection serviceCollection)
    {
        return TestDetector.IsInTest;
    }
}