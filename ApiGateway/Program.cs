using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ApiGateway
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureAppConfiguration((hosting, config) =>
				{
					config
						.SetBasePath(hosting.HostingEnvironment.ContentRootPath)
						.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
						.AddJsonFile($"appsettings.{hosting.HostingEnvironment.EnvironmentName}.json", optional: true,
							reloadOnChange: true)
						.AddJsonFile($"configuration.{hosting.HostingEnvironment.EnvironmentName}.json")
						.AddEnvironmentVariables();

				})
				.ConfigureWebHostDefaults(builder =>
				{
					builder.UseStartup<Startup>();
				});
		
	}
}