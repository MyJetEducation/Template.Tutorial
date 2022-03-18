﻿using System;
using System.Runtime.Serialization;

namespace Service.TutorialBehavioral.Grpc.Models.State
{
	[DataContract]
	public class GetFinishStateGrpcRequest
	{
		[DataMember(Order = 1)]
		public Guid? UserId { get; set; }

		[DataMember(Order = 2)]
		public int? Unit { get; set; }
	}
}
