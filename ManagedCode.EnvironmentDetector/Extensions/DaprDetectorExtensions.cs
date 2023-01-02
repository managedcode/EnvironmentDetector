using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ManagedCode.EnvironmentDetector.Extensions;

public static class DaprDetectorExtensions
{
    public static bool IsDapr(this IHostEnvironment hostEnvironment)
    {
        return DaprDetector.IsInDapr;
    }
    
    public static bool IsDapr(this IServiceCollection serviceCollection)
    {
        return DaprDetector.IsInDapr;
    }
}