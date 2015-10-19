using System;
using System.Collections.Generic;

namespace Workflow.Common.Models
{
    public class User
    {
        public int? UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Process> AdministeredProcesses { get; set; }

        public ICollection<Request> StakeRequests { get; set; }

        public ICollection<RequestNote> RequestNotes { get; set; }
    }
}
