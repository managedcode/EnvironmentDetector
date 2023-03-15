using System.Diagnostics;

namespace ManagedCode.EnvironmentDetector;

public static class DebuggerDetector
{
    static DebuggerDetector()
    {
        IsInDebug = Debugger.IsAttached;
    }

    public static bool IsInDebug { get; }
}