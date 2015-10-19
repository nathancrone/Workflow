using System.Collections.Generic;

namespace Workflow.Common.Models
{
    public class ActivityType
    {
        public int? ActivityTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Activity> Activities { get; set; }
    }
}
