using System.Collections.Generic;
using Workflow.Common.Models;

namespace Workflow.Common.Services
{
    public interface IRequestDataService : IService<RequestData>
    {
        IEnumerable<RequestData> GetAll();
    }
}
