namespace ManagedCode.TestsDetector;

public static class MSTestDetector
{
    static MSTestDetector()
    {
        IsInTest = AppDomain.CurrentDomain.GetAssemblies()
            .Any(a => a.FullName?.Contains("MSTest", StringComparison.InvariantCultureIgnoreCase) ?? false);
    }

    public static bool IsInTest { get; }
}

