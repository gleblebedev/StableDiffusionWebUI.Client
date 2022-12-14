// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace StableDiffusionWebUI.Client.Models
{
    /// <summary> Estimation. </summary>
    public partial class Estimation
    {
        /// <summary> Initializes a new instance of Estimation. </summary>
        /// <param name="queueSize"> Queue Size. </param>
        /// <param name="queueEta"> Queue Eta. </param>
        internal Estimation(int queueSize, int queueEta)
        {
            QueueSize = queueSize;
            QueueEta = queueEta;
        }

        /// <summary> Initializes a new instance of Estimation. </summary>
        /// <param name="msg"> Msg. </param>
        /// <param name="rank"> Rank. </param>
        /// <param name="queueSize"> Queue Size. </param>
        /// <param name="avgEventProcessTime"> Avg Event Process Time. </param>
        /// <param name="avgEventConcurrentProcessTime"> Avg Event Concurrent Process Time. </param>
        /// <param name="rankEta"> Rank Eta. </param>
        /// <param name="queueEta"> Queue Eta. </param>
        internal Estimation(string msg, int? rank, int queueSize, float? avgEventProcessTime, float? avgEventConcurrentProcessTime, int? rankEta, int queueEta)
        {
            Msg = msg;
            Rank = rank;
            QueueSize = queueSize;
            AvgEventProcessTime = avgEventProcessTime;
            AvgEventConcurrentProcessTime = avgEventConcurrentProcessTime;
            RankEta = rankEta;
            QueueEta = queueEta;
        }

        /// <summary> Msg. </summary>
        public string Msg { get; }
        /// <summary> Rank. </summary>
        public int? Rank { get; }
        /// <summary> Queue Size. </summary>
        public int QueueSize { get; }
        /// <summary> Avg Event Process Time. </summary>
        public float? AvgEventProcessTime { get; }
        /// <summary> Avg Event Concurrent Process Time. </summary>
        public float? AvgEventConcurrentProcessTime { get; }
        /// <summary> Rank Eta. </summary>
        public int? RankEta { get; }
        /// <summary> Queue Eta. </summary>
        public int QueueEta { get; }
    }
}
