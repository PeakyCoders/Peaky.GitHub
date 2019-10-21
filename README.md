# Peaky.GitHub.Webhooks
GitHub Webhooks implementation in .NET Standard 2.0

# NuGet
Both `Peaky.GitHub.AspNetCore` and `Peaky.GitHub.Webhooks` generate NuGet packages.

Packages need to be generated thorugh the CLI in order to support the multiple framework targets in `Peaky.GitHub.AspNetCore` (for both ASP.NET Core 2.2 and ASP.NET Core 3.0).

The following CLI command must be run in the root folder:

`dotnet pack -c Release`

Which will generate two `.nupkg` files:

```
.\Peaky.GitHub.Webhooks\bin\Release\Peaky.GitHub.Webhooks.X.Y.Z.nupkg
.\Peaky.GitHub.Webhooks.AspNetCore\bin\Release\Peaky.GitHub.Webhooks.AspNetCore.X.Y.Z.nupkg
```

Those can be manually uploaded to [nuget.org/packages/manage/upload](https://www.nuget.org/packages/manage/upload).
