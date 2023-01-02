namespace ManagedCode.EnvironmentDetector;

public static class DaprDetector
{
    static DaprDetector()
    {
        var x = Environment.GetEnvironmentVariables().Keys.Cast<string>()
            .Any(k => k.ToUpperInvariant().Contains("DAPR_"));
    }

    public static bool IsInDapr { get; }
}