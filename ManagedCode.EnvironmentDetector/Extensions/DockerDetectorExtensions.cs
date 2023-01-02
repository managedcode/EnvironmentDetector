using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ManagedCode.EnvironmentDetector.Extensions;

public static class DockerDetectorExtensions
{
    public static bool IsDocker(this IHostEnvironment hostEnvironment)
    {
        return DockerDetector.IsInDocker;
    }
    
    public static bool IsDocker(this IServiceCollection serviceCollection)
    {
        return DockerDetector.IsInDocker;
    }
}