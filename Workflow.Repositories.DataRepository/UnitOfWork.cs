using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workflow.Common;
using Workflow.Common.Models;
using Workflow.Common.Repositories;

namespace Workflow.Repositories.DataRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private DataContext _context = new DataContext();

        private ProcessRepository processRepository;

        public void Save()
        {
            throw new NotImplementedException();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
