using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.ApplicationInsights;

namespace UTCL.Confluence.Audit
{
    public class Program
    {

        public static void Main(string[] args)
        {
            CreateHostBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory()).Build().Run();
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                //.ConfigureAppConfiguration((context, config) =>
                //{
                //    var keyVaultEndpoint = GetKeyVaultEndpoint();
                //    if (!string.IsNullOrEmpty(keyVaultEndpoint))
                //    {
                //        var azureServiceTokenProvider = new AzureServiceTokenProvider();
                //        var keyVaultClient = new KeyVaultClient(
                //            new KeyVaultClient.AuthenticationCallback(
                //                azureServiceTokenProvider.KeyVaultTokenCallback));
                //        config.AddAzureKeyVault(keyVaultEndpoint, keyVaultClient, new DefaultKeyVaultSecretManager());
                //    }
                //})
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
                    webBuilder.UseStartup<Startup>().ConfigureLogging((hostingContext, builder) =>
                    {
                        var config = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json", optional: false)
                        .AddJsonFile($"appsettings.{environment}.json")
                        .Build();
                        var configSectionForLogging = hostingContext.Configuration.GetSection("Logging");

                        builder.AddApplicationInsights(config.GetSection("ApplicationInsights").GetSection("InstrumentationKey").Value);
                        builder.AddFilter<ApplicationInsightsLoggerProvider>("", System.Enum.Parse<LogLevel>(configSectionForLogging["LogLevel:Default"] ?? "Information"));
                        builder.AddFilter<ApplicationInsightsLoggerProvider>("Microsoft", System.Enum.Parse<LogLevel>(configSectionForLogging["LogLevel:Microsoft"] ?? "Microsoft"));
                    });
                });

        //private static string GetKeyVaultEndpoint() => "https://utcl-confluence-kv-dev.vault.azure.net/";
    }
}
