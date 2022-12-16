namespace ManagedCode.TestsDetector;

public static class XUnitDetector
{
    static XUnitDetector()
    {
        IsInTest = AppDomain.CurrentDomain.GetAssemblies()
            .Any(a => a.FullName?.Contains("xUnit", StringComparison.InvariantCultureIgnoreCase) ?? false);
    }

    public static bool IsInTest { get; }
}