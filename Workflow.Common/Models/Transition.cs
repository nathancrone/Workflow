using System.Collections.Generic;

namespace Workflow.Common.Models
{
    public class Transition
    {
        public int? TransitionId { get; set; }
        public int? ProcessId { get; set; }
        public int? CurrentStateId { get; set; }
        public int? NextStateId { get; set; }

        public virtual Process Process { get; set; }
        public virtual State CurrentState { get; set; }
        public virtual State NextState { get; set; }

        public ICollection<Action> Actions { get; set; }
        public ICollection<Activity> Activities { get; set; }
    }
}
