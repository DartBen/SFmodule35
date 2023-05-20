using System.Collections;

namespace SocialNetwork.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        IAsyncEnumerable<T> GetAll();
        Task<T> Get(int id);
        Task Create(T item);
        Task Update(T item);
        Task Delete(T item);
    }
}
