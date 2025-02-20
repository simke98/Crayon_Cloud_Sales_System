using Crayon.CSS.Api;
using Crayon.CSS.Persistence;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();
        EnsureDatabaseUpdated(host);
        host.Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
     Host.CreateDefaultBuilder(args)
         .ConfigureWebHostDefaults(webBuilder =>
         {
             webBuilder.UseStartup<Startup>();
         });

    public static void EnsureDatabaseUpdated(IHost host)
    {
        using var scope = host.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<CSSDBContext>();
        context.Database.Migrate();
    }
}
