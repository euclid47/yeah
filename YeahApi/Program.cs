using System.Net;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace YeahApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
	        DotNetEnv.Env.Load();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
	            .UseKestrel(options =>
	            {
					options.Listen(IPAddress.Any, 5000);
					options.Listen(IPAddress.Any, 5001, configure =>
						{
							configure.UseHttps(DotNetEnv.Env.GetString("pfx"), DotNetEnv.Env.GetString("pfxpassword"));
						});
	            })
                .UseStartup<Startup>();
    }
}
