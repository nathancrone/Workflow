using System.Linq;
using Workflow.Common.Models;

namespace Workflow.Common.Repositories
{
    public interface IRequestRepository : IRepository<Request>
    {
        //Query Methods
        IQueryable<Request> GetAll();
    }
}
