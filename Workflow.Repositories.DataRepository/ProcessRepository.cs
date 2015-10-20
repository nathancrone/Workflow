using System;
using System.Linq;
using Workflow.Common.Models;
using Workflow.Common.Repositories;

namespace Workflow.Repositories.DataRepository
{
    public class ProcessRepository : GenericRepository<Process>, IProcessRepository
    {
        public ProcessRepository(DataContext context) : base(context) { }

        public IQueryable<Process> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
