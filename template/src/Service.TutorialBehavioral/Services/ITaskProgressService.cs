using System;
using System.Threading.Tasks;
using Service.Education.Structure;
using Service.TutorialBehavioral.Grpc.Models.State;
using Service.TutorialBehavioral.Grpc.Models.Task;
using Service.TutorialBehavioral.Models;

namespace Service.TutorialBehavioral.Services
{
	public interface ITaskProgressService
	{
		ValueTask<TestScoreGrpcResponse> SetTaskProgressAsync(Guid? userId, EducationStructureUnit unit, EducationStructureTask task, bool isRetry, TimeSpan duration, int? progress = null);

		ValueTask<StateGrpcModel> GetUnitProgressAsync(Guid? userId, int unit);

		ValueTask<TaskTypeProgressInfo> GetTotalProgressAsync(Guid? userId, int? unit = null);
	}
}
