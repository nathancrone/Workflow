using System;
using System.Collections.Generic;

using Workflow.Contracts.Models;

namespace Workflow.Models
{
    public class User
    {
        public int? UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Process> AdministeredProcesses { get; set; }

        public ICollection<Request> StakeRequests { get; set; }
    }
}
