using System.Collections.Generic;

namespace Workflow.Contracts.Models
{
    public interface IUser
    {
        int? UserId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

        ICollection<IProcess> AdministeredProcesses { get; set; }
        ICollection<IRequest> StakeRequests { get; set; }
    }
}
