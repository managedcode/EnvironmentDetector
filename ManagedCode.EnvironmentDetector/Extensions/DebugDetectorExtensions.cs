using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ManagedCode.EnvironmentDetector.Extensions;

public static class DebugDetectorExtensions
{
    public static bool IsDebug(this IHostEnvironment hostEnvironment)
    {
        return DebuggerDetector.IsInDebug;
    }
    
    public static bool IsDebug(this IServiceCollection serviceCollection)
    {
        return DebuggerDetector.IsInDebug;
    }
}