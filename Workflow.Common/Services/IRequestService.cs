using System.Collections.Generic;
using Workflow.Common.Models;

namespace Workflow.Common.Services
{
    public interface IRequestService : IService<Request>
    {
        IEnumerable<Request> GetAll();
    }
}
