# TestsDetector

[![.NET](https://github.com/managedcode/TestsDetector/actions/workflows/dotnet.yml/badge.svg)](https://github.com/managedcode/TestsDetector/actions/workflows/dotnet.yml)
[![Coverage Status](https://coveralls.io/repos/github/managedcode/TestsDetector/badge.svg?branch=main&service=github)](https://coveralls.io/github/managedcode/TestsDetector?branch=main)
[![nuget](https://github.com/managedcode/TestsDetector/actions/workflows/nuget.yml/badge.svg?branch=main)](https://github.com/managedcode/TestsDetector/actions/workflows/nuget.yml)
[![CodeQL](https://github.com/managedcode/TestsDetector/actions/workflows/codeql-analysis.yml/badge.svg?branch=main)](https://github.com/managedcode/TestsDetector/actions/workflows/codeql-analysis.yml)
[![NuGet Package](https://img.shields.io/nuget/v/ManagedCode.TestsDetector.svg)](https://www.nuget.org/packages/ManagedCode.TestsDetector)



TestsDetector is a library that provides a simple way to detect whether your code is running in a test environment or not.
It currently supports detecting MSTest, NUnit, and xUnit test frameworks.

## Installation

To use TestsDetector in your project, you'll need to install the NuGet package. 
You can do this by running the following command in the Package Manager Console:

```Install-Package ManagedCode.TestsDetector```

Alternatively, you can search for "ManagedCode.TestsDetector" in the NuGet Package Manager in Visual Studio.

## Usage

TestsDetector provides two ways to detect whether your code is running in a test environment or not.

The first way is to use the provided extension method IsTests on an instance of IHostEnvironment. Here's an example of how you might use this method in a Razor page:

```csharp
if (HostEnvironment.IsTests())
{
    app.AddFake();
}
else
{
    app.AddReal();
}
```

The second way to use TestsDetector is to use the MSTestDetector.IsInTest static property. This can be useful if you don't have access to an instance of IHostEnvironment, or if you want to check whether you're running in a test environment in a static context. Here's an example of how you might use this property:

```csharp
using ManagedCode.TestsDetector;

if (MSTestDetector.IsInTest)
{
    Console.WriteLine("Running in a test environment");
}
else
{
    Console.WriteLine("Running in a production environment");
}
```


## Motivation

When working on a software project, it's common to have both production code and test code in the same repository. 
However, it can sometimes be useful to be able to distinguish between the two, especially when working with dependency injection.

The TestsDetector project aims to provide a simple and convenient way to detect whether your code is running in a test environment or not. 
By using TestsDetector, you'll be able to easily check whether you're running in a test environment or not, 
and configure your dependency injection container accordingly. TestsDetector currently supports MSTest, NUnit, and xUnit test frameworks.


## Limitations

TestsDetector uses reflection to detect the presence of test frameworks. 
This means that it may not work in all cases, especially if the test framework is being used in an unusual way. 
However, it should work in most cases.

## Contributions

We welcome contributions to TestsDetector! 
If you have an idea for a new feature or have found a bug, please open an issue on GitHub. 
If you'd like to contribute code, please fork the repository and submit a pull request.