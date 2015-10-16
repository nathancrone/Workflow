namespace Workflow.Contracts.Models
{
    public interface IProcess
    {
        int? ProcessId { get; set; }
        string Name { get; set; }
    }
}
