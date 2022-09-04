using CodTrackerBlazorUI.Setup;

WebApplication
    .CreateBuilder(args)
    .AddServices()
    .Build()
    .UseMiddleware()
    .Run();
