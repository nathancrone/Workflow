namespace Workflow.Contracts.Repositories
{
    public interface IRepository<T>
    {
        //Query Methods
        T FindById(int id);

        // Insert/Delete
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        //Persistence
        void Save();
    }
}
