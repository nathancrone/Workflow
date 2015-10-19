using System.Collections.Generic;
using Workflow.Common.Models;

namespace Workflow.Common.Services
{
    public interface IRequestNoteService : IService<RequestNote>
    {
        IEnumerable<RequestNote> GetAll();
    }
}
