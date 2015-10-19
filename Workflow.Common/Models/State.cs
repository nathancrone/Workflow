using System.Collections.Generic;

namespace Workflow.Common.Models
{
    public class State
    {
        public int? StateId { get; set; }
        public int? ProcessId { get; set; }
        public int? StateTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Process Process { get; set; }
        public virtual StateType StateType { get; set; }

        public ICollection<Transition> Transitions { get; set; }
        public ICollection<Action> Actions { get; set; }
        public ICollection<Activity> Activities { get; set; }
    }
}
