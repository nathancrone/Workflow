using System.Linq;
using Workflow.Contracts.Models;

namespace Workflow.Contracts.Repositories
{
    public interface IProcessRepository : IRepository<IProcess>
    {
        //Query Methods
        IQueryable<IProcess> GetAll();
    }
}
