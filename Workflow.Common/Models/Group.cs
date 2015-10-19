using System;
using System.Collections.Generic;

namespace Workflow.Common.Models
{
    public class Group
    {
        public int? GroupId { get; set; }
        public int? ProcessId { get; set; }
        public string Name { get; set; }

        public virtual Process Process { get; set; }

        public ICollection<User> Members { get; set; }

        public ICollection<ActionTarget> ActionTargets { get; set; }
        public ICollection<ActivityTarget> ActivityTargets { get; set; }
    }
}
