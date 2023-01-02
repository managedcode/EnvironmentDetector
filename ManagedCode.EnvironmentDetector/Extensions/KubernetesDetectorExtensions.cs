using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ManagedCode.EnvironmentDetector.Extensions;

public static class KubernetesDetectorExtensions
{
    public static bool IsKubernetes(this IHostEnvironment hostEnvironment)
    {
        return KubernetesDetector.IsInKubernetes;
    }
    
    public static bool IsKubernetes(this IServiceCollection serviceCollection)
    {
        return KubernetesDetector.IsInKubernetes;
    }
}