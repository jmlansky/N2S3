using DbFunctions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Alter_N2S3_Db
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var result = host.Services.GetService<IFunctions>().AlterTable();

            Console.WriteLine($"Resultado de la actualizacion: {result}");
            Console.WriteLine($"Presione cualquier tecla para terminar!!!");
            Console.ReadKey();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            var hostBuilder = Host.CreateDefaultBuilder(args).ConfigureAppConfiguration((context, builder) =>
            {
                builder.SetBasePath(Directory.GetCurrentDirectory());
            })
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<IFunctions, DbScripts>();
                });

            return hostBuilder;
        }
    }
}
