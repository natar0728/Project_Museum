using Museum.Models;

namespace Museum.Repository.IRepository
{
    public interface IExposicionRepository : IRepository<Exposicion>
    {
        Task<Exposicion> Update(Exposicion entity);
    }
}
