using System.Collections.Generic;
using Workflow.Contracts.Models;

namespace Workflow.Contracts.Services
{
    public interface IProcessService : IService<IProcess>
    {
        IEnumerable<IProcess> GetAll();
    }
}
