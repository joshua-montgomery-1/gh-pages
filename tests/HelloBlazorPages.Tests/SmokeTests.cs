using System.Reflection;

namespace HelloBlazorPages.Tests;

public class SmokeTests
{
    [Fact]
    public void ApplicationAssembly_IsDiscoverable()
    {
        var assembly = typeof(HelloBlazorPages.App).Assembly;

        Assert.Equal("HelloBlazorPages", assembly.GetName().Name);
    }

    [Fact]
    public void HomeRoute_ComponentExists()
    {
        var homeType = typeof(HelloBlazorPages.Pages.Home);

        var routeAttribute = homeType.GetCustomAttribute<Microsoft.AspNetCore.Components.RouteAttribute>();

        Assert.NotNull(routeAttribute);
        Assert.Equal("/", routeAttribute!.Template);
    }
}
