namespace eTicket.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        public void UpdateAsync(T entity);
        Task RemoveAsync(int id); 
        Task CompleteAsync();
    }
}