using Workflow.Contracts.Models;

namespace Workflow.Models
{
    public class Process : IProcess
    {
        public int? ProcessId { get; set; }

        public string Name { get; set; }
    }
}
