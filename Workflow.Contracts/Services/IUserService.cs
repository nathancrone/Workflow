using System.Collections.Generic;
using Workflow.Contracts.Models;

namespace Workflow.Contracts.Services
{
    public interface IUserService : IService<IUser>
    {
        IEnumerable<IUser> GetAll();
    }
}
