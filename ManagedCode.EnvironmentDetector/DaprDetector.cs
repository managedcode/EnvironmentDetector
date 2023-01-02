namespace ManagedCode.EnvironmentDetector;

public static class DaprDetector
{
    static DaprDetector()
    {
        IsInDapr = Environment.GetEnvironmentVariables().Cast<KeyValuePair<string,string>?>()
            .Any(k => k.HasValue && k.Value.Key.ToUpperInvariant().Contains("DAPR_"));
    }

    public static bool IsInDapr { get; }
}