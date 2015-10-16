using System.Collections.Generic;
using Workflow.Contracts.Models;

namespace Workflow.Contracts.Services
{
    public interface IRequestService : IService<IRequest>
    {
        IEnumerable<IRequest> GetAll();
    }
}
