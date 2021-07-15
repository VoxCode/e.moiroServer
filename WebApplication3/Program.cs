using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
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
                    webBuilder.ConfigureKestrel(options =>
                    {
                        options.Limits.MaxConcurrentConnections = 20;
                        options.Listen(IPAddress.Any, 5009, listenOptions =>
                        {
                            listenOptions.UseHttps("/etc/letsencrypt/live/api.smart.moiro.by/cert.pfx",
                                "/etc/letsencrypt/live/api.smart.moiro.by/password");
                        });
                    });
                    webBuilder.UseStartup<Startup>();
                });
    }
}
