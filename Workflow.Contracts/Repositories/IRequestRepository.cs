using System.Linq;
using Workflow.Contracts.Models;

namespace Workflow.Contracts.Repositories
{
    public interface IRequestRepository : IRepository<IRequest>
    {
        //Query Methods
        IQueryable<IRequest> GetAll();
    }
}
