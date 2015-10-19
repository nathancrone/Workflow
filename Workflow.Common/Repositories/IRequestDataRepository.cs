using System.Linq;
using Workflow.Common.Models;

namespace Workflow.Common.Repositories
{
    public interface IRequestDataRepository : IRepository<RequestData>
    {
        //Query Methods
        IQueryable<RequestData> GetAll();
    }
}
