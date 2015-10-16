using System;
using System.Collections.Generic;
using Workflow.Contracts.Models;

namespace Workflow.Models
{
    public class Request
    {
        public int? RequestId { get; set; }

        public int? ProcessId { get; set; }

        public int? UserId { get; set; }

        public string Title { get; set; }

        public DateTime DateRequested { get; set; }

        public ICollection<User> Stakeholders { get; set; }
    }
}
