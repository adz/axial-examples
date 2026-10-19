# Axial integration examples

Cross-product examples using released [Axial](https://github.com/adz/Axial), [Reified](https://github.com/adz/Reified), and [Elmish.Avalonia.Glue](https://github.com/adz/Elmish.Avalonia.Glue) packages. See those repositories for documentation.

- **Axial.ReferenceApp**: observability, workflows, persistence and HTTP in one application; [details and commands](examples/Axial.ReferenceApp/README.md). Run `dotnet run --project examples/Axial.ReferenceApp -- list`.
- **Axial.Hosting.AspNetCore.Example**: Reified HTTP contracts served via ASP.NET Core. Run `dotnet run --project examples/Axial.Hosting.AspNetCore.Example`.
- **Axial.Hosting.GenHttp.Example**: Reified HTTP contracts served via GenHTTP. Run `dotnet run --project examples/Axial.Hosting.GenHttp.Example`.

Build and test with `dotnet build` and `dotnet test` (SDK 10.0.402).
