namespace ManagedCode.EnvironmentDetector;

public static class NUnitDetector
{
    static NUnitDetector()
    {
        IsInTest = AppDomain.CurrentDomain.GetAssemblies()
            .Any(a => a.FullName?.Contains("NUnit", StringComparison.InvariantCultureIgnoreCase) ?? false);
    }

    public static bool IsInTest { get; }
}