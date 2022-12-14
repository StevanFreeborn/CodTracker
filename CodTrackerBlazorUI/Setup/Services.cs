using CodTrackerInfrastructure;

namespace CodTrackerBlazorUI.Setup;

public static class Services
{
    public static WebApplicationBuilder AddServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddRazorPages();

        builder.Services.AddServerSideBlazor();

        builder.Services.AddInfrastructureServices(builder.Configuration);

        return builder;
    }
}
