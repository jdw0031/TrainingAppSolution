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

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDefaultIdentity<ApplicationUser>()
            .AddEntityFrameworkStores<ApplicationDbContext>();
//builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<ITrainerRepo, TrainerRepo>();
builder.Services.AddTransient<ITrainerScheduleRepo, TrainerScheduleRepo>();
builder.Services.AddTransient<IApplicationUserRepo, ApplicationUserRepo>();
builder.Services.AddTransient<ITrainingSessionRepo, TrainingSessionRepo>();
builder.Services.AddTransient<IEmailSender, EmailSender>();
//builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");

app.Run();

//namespace TrainingApp
//{
//    public class Program
//    {
//        // the sole purpose of this code is to help the connect to the database
//        public static void Main(string[] args)
//        {
//            //CreateHostBuilder(args).Build().Run();
//            var host = CreateWebHostBuilder(args).Build();

//            using (var scope = host.Services.CreateScope())
//            {
//                var services = scope.ServiceProvider;

//                try
//                {
//                    DbInitializer.Initialize(services).Wait();
//                }
//                catch (Exception ex)
//                {
//                    var logger = services.GetRequiredService<ILogger<Program>>();
//                    logger.LogError(ex, "An error occured creating the DB.");
//                }
//            }

//            host.Run();

//        } // end of main method

//        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
//            WebHost.CreateDefaultBuilder(args)
//                    .UseStartup<Startup>();
//            }
//}
