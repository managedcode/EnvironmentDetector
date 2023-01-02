namespace ManagedCode.EnvironmentDetector;

public static class DaprDetector
{
    static DaprDetector()
    {
        IsInDapr = Environment.GetEnvironmentVariables().Keys.Cast<string>()
            .Any(k => k.ToUpperInvariant().Contains("DAPR_"));
    }

    public static bool IsInDapr { get; }
}