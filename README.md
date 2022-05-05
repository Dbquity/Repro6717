# Repro6717

Before the reference to ClassLibrary1 (3'rd commit in this repo)

```msbuild MauiApp1 /restore /p:TargetFramework=net6.0-windows10.0.19041.0```

succeeds.

After depending on the .NET6 class library, it yields:

```
Done Building Project "C:\Code\Maui\Repro6717\MauiApp1\MauiApp1.csproj" (Restore target(s)) -- FAILED.


Build FAILED.

"C:\Code\Maui\Repro6717\MauiApp1\MauiApp1.csproj" (Restore target) (1) ->
(Restore target) ->
  C:\Code\Maui\Repro6717\MauiApp1\MauiApp1.csproj : error NU1201: Project ClassLibrary1 is not compatible with net6.0-a
ndroid31.0 (.NETCoreApp,Version=v6.0). Project ClassLibrary1 supports: net6.0-windows10.0.19041 (.NETCoreApp,Version=v6
.0)
  C:\Code\Maui\Repro6717\MauiApp1\MauiApp1.csproj : error NU1201: Project ClassLibrary1 is not compatible with net6.0-i
os15.4 (.NETCoreApp,Version=v6.0). Project ClassLibrary1 supports: net6.0-windows10.0.19041 (.NETCoreApp,Version=v6.0)
  C:\Code\Maui\Repro6717\MauiApp1\MauiApp1.csproj : error NU1201: Project ClassLibrary1 is not compatible with net6.0-m
accatalyst15.4 (.NETCoreApp,Version=v6.0). Project ClassLibrary1 supports: net6.0-windows10.0.19041 (.NETCoreApp,Versio
n=v6.0)
  C:\Code\Maui\Repro6717\MauiApp1\MauiApp1.csproj : error NU1201: Project ClassLibrary1 is not compatible with net6.0-a
ndroid31.0 (.NETCoreApp,Version=v6.0) / win10-x64. Project ClassLibrary1 supports: net6.0-windows10.0.19041 (.NETCoreAp
p,Version=v6.0)
  C:\Code\Maui\Repro6717\MauiApp1\MauiApp1.csproj : error NU1201: Project ClassLibrary1 is not compatible with net6.0-i
os15.4 (.NETCoreApp,Version=v6.0) / win10-x64. Project ClassLibrary1 supports: net6.0-windows10.0.19041 (.NETCoreApp,Ve
rsion=v6.0)
  C:\Code\Maui\Repro6717\MauiApp1\MauiApp1.csproj : error NU1201: Project ClassLibrary1 is not compatible with net6.0-m
accatalyst15.4 (.NETCoreApp,Version=v6.0) / win10-x64. Project ClassLibrary1 supports: net6.0-windows10.0.19041 (.NETCo
reApp,Version=v6.0)

    0 Warning(s)
    6 Error(s)

Time Elapsed 00:00:02.63
```
