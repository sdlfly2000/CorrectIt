using Common.Core.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Infrastructure.Data.Sql;

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
                .UseSystemd()
                .ConfigureServices((hostContext, services) =>
                {                 
                    DIModule.RegisterDependency(services);
                    services.AddDbContext<CorrectItDbContext>(
                            options =>
                                options.UseMySql(
                                    hostContext.Configuration.GetConnectionString("CorrectItWeb"),
                                    b => b.MigrationsAssembly("Infrastructure.Data.Sql")));
                    services.AddHostedService<Worker>();
                });
    }
}
