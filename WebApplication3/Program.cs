using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Hosting;
using System;
using System.Net;

namespace e.moiroServer
{
    public class Program
    {
        public static void Main(string[] args)
            => CreateHostBuilder(args)
                .Build()
                .Run();

        public static IHostBuilder CreateHostBuilder(string[] args)
            => Host
                .CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseKestrel(options =>
                    {
                        options.Limits.MaxConcurrentConnections = 20;
                        options.Limits.MaxRequestBodySize = 10 * 1024;
                        options.Limits.MinRequestBodyDataRate =
                            new MinDataRate(bytesPerSecond: 100, gracePeriod: TimeSpan.FromSeconds(10));
                        options.Limits.MinResponseDataRate =
                            new MinDataRate(bytesPerSecond: 100, gracePeriod: TimeSpan.FromSeconds(10));
                        options.Listen(IPAddress.Loopback, 5009);
                        options.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(2);
                        options.Limits.RequestHeadersTimeout = TimeSpan.FromMinutes(1);
                    });
                    webBuilder.UseStartup<Startup>();
                });
    }
}
