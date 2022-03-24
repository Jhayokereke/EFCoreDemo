using AutoMapper;
using EFCoreDemo.UI.Core;
using EFCoreDemo.UI.Data;
using EFCoreDemo.UI.Entities;
using EFCoreDemo.UI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System;
using System.IO;
using System.Windows.Forms;

namespace EFCoreDemo.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
            var services = new ServiceCollection();
            services.ConfigureServices(config);
            var fellowService = services.BuildServiceProvider().GetRequiredService<IFellowService>();
            Application.Run(new BaseForm(fellowService));
        }

        static void ConfigureServices(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddAutoMapper(cfg =>
            {
                cfg.CreateMap<DotnetFellow, GetFellowResponse>()
                .ForMember(d => d.StateName, opt => opt.MapFrom(s => s.State.Name))
                .ForMember(d => d.Gender, opt => opt.MapFrom(s => ((Gender)s.GenderId).ToString()));
                cfg.CreateMap<RegisterFellowRequest, DotnetFellow>();
            });
            service.AddLogging(builder =>
            {
                builder.ClearProviders();
                builder.SetMinimumLevel(LogLevel.Information);
                builder.AddNLog(configuration);
            });
            service.AddDbContext<TheBulbDBContext>(builder => { builder.UseSqlServer(@"Data Source = .; Initial Catalog = TheBulbDB; Integrated Security = True"); });
            service.AddScoped<IFellowRepository>( x => new FellowRepository(x.GetRequiredService<TheBulbDBContext>()));
            service.AddScoped<IFellowService>(x => new FellowService(
                x.GetRequiredService<IFellowRepository>(), 
                x.GetRequiredService<IMapper>(), 
                x.GetService<ILogger<FellowService>>())
            );
        }
    }
}
