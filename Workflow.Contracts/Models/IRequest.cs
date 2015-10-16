using System;

namespace Workflow.Contracts.Models
{
    public interface IRequest
    {
        int? RequestId { get; set; }
        string Title { get; set; }
        DateTime DateRequested { get; set; }
    }
}
