using System.Collections.Generic;
using Workflow.Common.Models;

namespace Workflow.Common.Services
{
    public interface IUserService : IService<User>
    {
        IEnumerable<User> GetAll();
    }
}
