using System.Linq;
using Workflow.Common.Models;

namespace Workflow.Common.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        //Query Methods
        IQueryable<User> GetAll();
    }
}
