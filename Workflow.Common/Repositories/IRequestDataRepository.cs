using System.Linq;
using Workflow.Common.Models;

namespace Workflow.Common.Repositories
{
    public interface IRequestDataRepository : IGenericRepository<RequestData>
    {
        //Query Methods
        IQueryable<RequestData> GetAll();
    }
}
