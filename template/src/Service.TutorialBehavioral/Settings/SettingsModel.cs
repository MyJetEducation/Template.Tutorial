using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.TutorialBehavioral.Settings
{
	public class SettingsModel
	{
		[YamlProperty("TutorialBehavioral.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("TutorialBehavioral.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("TutorialBehavioral.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("TutorialBehavioral.EducationProgressServiceUrl")]
		public string EducationProgressServiceUrl { get; set; }

		[YamlProperty("TutorialBehavioral.EducationRetryServiceUrl")]
		public string EducationRetryServiceUrl { get; set; }

		[YamlProperty("TutorialBehavioral.UserRewardServiceUrl")]
		public string UserRewardServiceUrl { get; set; }

		[YamlProperty("TutorialBehavioral.UserProgressServiceUrl")]
		public string UserProgressServiceUrl { get; set; }
	}
}