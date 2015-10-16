using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Workflow.Repositories.DataRepository.Models;

namespace Workflow.Repositories.DataRepository
{
    class DataContext : DbContext
    {
        public virtual DbSet<Process> Processes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
    }
}
