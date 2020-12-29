using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace RsoSem1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                //var settings = config.Build();
                //options.Connect(settings["ConnectionStrings:AppConfig"])


                //var connection = settings.GetConnectionString("AppConfig");

                //config.AddAzureAppConfiguration(connection);
                config.AddAzureAppConfiguration(options =>
                {
                    options.Connect(Environment.GetEnvironmentVariable("APP_CONFIG_CONN_STRING"))
                           .ConfigureRefresh(refresh =>
                           {
                               refresh.Register("TestApp:Settings:Message", refreshAll: true)
                                  .SetCacheExpiration(new TimeSpan(0, 1, 0));
                           });
                });
            })
            .UseStartup<Startup>();
    }
}


//Environment.GetEnvironmentVariable("Test1");