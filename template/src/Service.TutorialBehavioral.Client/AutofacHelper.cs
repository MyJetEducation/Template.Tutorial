using Autofac;
using Microsoft.Extensions.Logging;
using Service.Grpc;
using Service.TutorialBehavioral.Grpc;

// ReSharper disable UnusedMember.Global

namespace Service.TutorialBehavioral.Client
{
	public static class AutofacHelper
	{
		public static void RegisterTutorialBehavioralClient(this ContainerBuilder builder, string grpcServiceUrl, ILogger logger)
		{
			var factory = new TutorialBehavioralClientFactory(grpcServiceUrl, logger);

			builder.RegisterInstance(factory.GetTutorialBehavioralService()).As<IGrpcServiceProxy<ITutorialBehavioralService>>().SingleInstance();
		}
	}
}
