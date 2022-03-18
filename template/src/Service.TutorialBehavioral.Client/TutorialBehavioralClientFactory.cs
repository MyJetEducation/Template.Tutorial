using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using Service.Grpc;
using Service.TutorialBehavioral.Grpc;

namespace Service.TutorialBehavioral.Client
{
	[UsedImplicitly]
	public class TutorialBehavioralClientFactory : GrpcClientFactory
	{
		public TutorialBehavioralClientFactory(string grpcServiceUrl, ILogger logger) : base(grpcServiceUrl, logger)
		{
		}

		public IGrpcServiceProxy<ITutorialBehavioralService> GetTutorialBehavioralService() => CreateGrpcService<ITutorialBehavioralService>();
	}
}