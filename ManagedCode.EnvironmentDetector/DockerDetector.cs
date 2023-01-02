namespace ManagedCode.EnvironmentDetector;

public static class DockerDetector
{
    static DockerDetector()
    {
        IsInDocker = Environment.GetEnvironmentVariables().Keys.Cast<string>()
            .Any(k => k.ToUpperInvariant().Contains("DOCKER_"));
    }

    public static bool IsInDocker { get; }
}