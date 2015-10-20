using System.Linq;
using Workflow.Common.Models;

namespace Workflow.Common.Repositories
{
    public interface IRequestNoteRepository : IGenericRepository<RequestNote>
    {
        //Query Methods
        IQueryable<RequestNote> GetAll();
    }
}
