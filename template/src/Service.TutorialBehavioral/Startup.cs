﻿using System.Reflection;
using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyJetWallet.Sdk.GrpcSchema;
using MyJetWallet.Sdk.Service;
using Prometheus;
using Service.Core.Client.Constants;
using Service.TutorialBehavioral.Grpc;
using Service.TutorialBehavioral.Modules;
using Service.TutorialBehavioral.Services;
using SimpleTrading.ServiceStatusReporterConnector;

namespace Service.TutorialBehavioral
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.BindCodeFirstGrpc();
			services.AddHostedService<ApplicationLifetimeManager>();
			services.AddMyTelemetry(Configuration.TelemetryPrefix, Program.Settings.ZipkinUrl);
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
				app.UseDeveloperExceptionPage();

			app.UseRouting();
			app.UseMetricServer();
			app.BindServicesTree(Assembly.GetExecutingAssembly());
			app.BindIsAlive();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapGrpcSchema<TutorialBehavioralService, ITutorialBehavioralService>();

				endpoints.MapGrpcSchemaRegistry();

				endpoints.MapGet("/", async context => await context.Response.WriteAsync("API endpoint"));
			});
		}

		public void ConfigureContainer(ContainerBuilder builder)
		{
			builder.RegisterModule<SettingsModule>();
			builder.RegisterModule<ServiceModule>();
		}
	}
}