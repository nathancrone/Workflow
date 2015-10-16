using System.Linq;
using Workflow.Contracts.Models;

namespace Workflow.Contracts.Repositories
{
    public interface IUserRepository : IRepository<IUser>
    {
        //Query Methods
        IQueryable<IUser> GetAll();
    }
}
