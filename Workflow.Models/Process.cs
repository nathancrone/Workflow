﻿using System.Collections.Generic;

namespace Workflow.Models
{
    public class Process 
    {
        public int? ProcessId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<User> ProcessAdmins { get; set; }
    }
}
