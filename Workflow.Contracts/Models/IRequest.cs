using System;
using System.Collections.Generic;

namespace Workflow.Contracts.Models
{
    public interface IRequest
    {
        int? RequestId { get; set; }
        string Title { get; set; }
        DateTime DateRequested { get; set; }

        ICollection<IUser> Stakeholders { get; set; }
    }
}
