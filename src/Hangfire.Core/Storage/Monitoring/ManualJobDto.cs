using System;
using Hangfire.Common;

namespace Hangfire.Storage.Monitoring
{
    public class ManualJobDto
    {
        public ManualJobDto()
        {
            InManualState = true;
        }

        public Job Job { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool InManualState { get; set; }
    }
}