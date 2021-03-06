﻿using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Sandbox.Api
{
	public class Program
	{
		public static void Main(string[] args)
		{
			WebHost.CreateDefaultBuilder(args)
				.ConfigureServices(s => s.AddAutofac())
				.UseStartup<Startup>()
				.Build().Run();
		}
			
	}
}
