using System.Linq;
using Workflow.Common.Models;

namespace Workflow.Common.Repositories
{
    public interface IRequestNoteRepository : IRepository<RequestNote>
    {
        //Query Methods
        IQueryable<RequestNote> GetAll();
    }
}
