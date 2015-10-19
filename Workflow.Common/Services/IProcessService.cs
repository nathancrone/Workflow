using System.Collections.Generic;
using Workflow.Common.Models;

namespace Workflow.Common.Services
{
    public interface IProcessService : IService<Process>
    {
        IEnumerable<Process> GetAll();
    }
}
