using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow.Contracts.Services
{
    public interface IService<T>
    {
        //Query Methods
        T FindById(int id);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
