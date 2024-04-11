using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using URLScanner.API;
using URLScanner.Models.Database;
using URLScanner.Services;

namespace URLScanner;

static class Program
{
    public static IServiceProvider ServiceProvider { get; private set; }

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        
        var builder = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        
        var configuration = builder.Build();
        var services = new ServiceCollection();
        ConfigureServices(services, configuration);
        
        ServiceProvider = services.BuildServiceProvider();
        using (var scope = ServiceProvider.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<URLScannerContext>();
            context.Database.EnsureCreated();
        }

        Application.Run(new Dashboard());
    }

    private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
       services.AddDbContext<URLScannerContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("ScannerDB")));
       services.AddSingleton<IConfiguration>(configuration);
       services.AddSingleton<ApiClient>();
       services.AddSingleton<AnalysisService>();
    }
}