using System.Linq;
using Workflow.Common.Models;

namespace Workflow.Common.Repositories
{
    public interface IProcessRepository : IRepository<Process>
    {
        //Query Methods
        IQueryable<Process> GetAll();
    }
}
