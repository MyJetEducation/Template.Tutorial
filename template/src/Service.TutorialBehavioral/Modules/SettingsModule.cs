﻿using Autofac;
using Service.Core.Client.Services;
using Service.TutorialBehavioral.Services;

namespace Service.TutorialBehavioral.Modules
{
	public class SettingsModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterInstance(Program.Settings).AsSelf().SingleInstance();
			builder.RegisterType<TaskProgressService>().AsImplementedInterfaces().SingleInstance();
			builder.RegisterType<SystemClock>().AsImplementedInterfaces().SingleInstance();
			builder.RegisterType<RetryTaskService>().AsImplementedInterfaces().SingleInstance();
		}
	}
}