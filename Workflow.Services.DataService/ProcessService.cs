using System;
using System.Linq;
using System.Collections.Generic;
using Workflow.Common.Models;
using Workflow.Common.Services;
using Workflow.Common.Repositories;

namespace Workflow.Services.DataService
{
    public class ProcessService : IProcessService
    {
        private IProcessRepository _repository;

        public ProcessService(IProcessRepository repository)
        {
            _repository = repository;
        }

        public Process FindById(int id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<Process> GetAll()
        {
            return _repository.GetAll().AsEnumerable<Process>();
        }

        public void Add(Process entity)
        {
            _repository.Insert(entity);
            _repository.Save();
        }

        public void Update(Process entity)
        {
            _repository.Update(entity);
            _repository.Save();
        }

        public void Delete(Process entity)
        {
            _repository.Delete(entity);
            _repository.Save();
        }

        #region IDisposable Support
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _repository.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
