namespace ManagedCode.EnvironmentDetector;

public static class KubernetesDetector
{
    static KubernetesDetector()
    {
        IsInKubernetes = Environment.GetEnvironmentVariables().Cast<KeyValuePair<string,string>?>().
            Any(k => k.HasValue && k.Value.Key.ToUpperInvariant().Contains("KUBERNETES_"));
    }

    public static bool IsInKubernetes { get; }
}