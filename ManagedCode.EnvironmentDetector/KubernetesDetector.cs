namespace ManagedCode.EnvironmentDetector;

public static class KubernetesDetector
{
    static KubernetesDetector()
    {
        IsInKubernetes = Environment.GetEnvironmentVariables().Keys.Cast<string>()
            .Any(k => k.ToUpperInvariant().Contains("KUBERNETES_"));
    }

    public static bool IsInKubernetes { get; }
}