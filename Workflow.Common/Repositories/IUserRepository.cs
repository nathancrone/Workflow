using System.Linq;
using Workflow.Common.Models;

namespace Workflow.Common.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        //Query Methods
        IQueryable<User> GetAll();
    }
}
