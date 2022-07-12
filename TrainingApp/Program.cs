using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TrainingApp.Data;
using TrainingApp.Models;
using TrainingApp.DataAccess.Repository.IRepository;
using TrainingApp.DataAccess.Repository;
using TrainingApp.Services;
using Microsoft.AspNetCore.Identity.UI.Services;
using TrainingApp;
using Microsoft.AspNetCore;

namespace TrainingApp
{
    public class Program
    {
        // the sole purpose of this code is to help the connect to the database
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    DbInitializer.Initialize(services).Wait();
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occured creating the DB.");
                }
            }

            host.Run();

        } // end of main method

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                    .UseStartup<Startup>();
    }
}
