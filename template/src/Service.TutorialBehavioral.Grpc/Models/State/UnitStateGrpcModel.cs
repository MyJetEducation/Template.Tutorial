﻿using System.Runtime.Serialization;

namespace Service.TutorialBehavioral.Grpc.Models.State
{
    [DataContract]
    public class StateGrpcModel
    {
        [DataMember(Order = 1)]
        public int Unit { get; set; }

        [DataMember(Order = 2)]
        public int TestScore { get; set; }

        [DataMember(Order = 3)]
        public TaskStateGrpcModel[] Tasks { get; set; }
    }

    [DataContract]
    public class TaskStateGrpcModel
    {
        [DataMember(Order = 1)]
        public int Task { get; set; }

        [DataMember(Order = 2)]
        public int TestScore { get; set; }

        [DataMember(Order = 3)]
        public TaskRetryInfoGrpcModel RetryInfo { get; set; }
    }
}
