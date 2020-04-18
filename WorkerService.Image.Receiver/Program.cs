using Common.Core.DependencyInjection;
using Infrastructure.Data.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WorkerService.Image.Receiver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();

                    DIModule.RegisterDependency(services);
                    services.AddDbContext<CorrectItDbContext>(
                            options =>
                                options.UseSqlServer(
                                    hostContext.Configuration.GetConnectionString("CorrectIt"),
                                    b => b.MigrationsAssembly("Infrastructure.Data.SqlServer")));
                });
    }
}
