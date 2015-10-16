using Workflow.Contracts.Models;

namespace Workflow.Models
{
    public class User : IUser
    {
        public int? UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
