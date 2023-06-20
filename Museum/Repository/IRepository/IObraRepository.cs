using Museum.Models;

namespace Museum.Repository.IRepository
{
    public interface IObraRepository : IRepository<Obra>
    {
        Task<Obra> Update(Obra entity);
    }
}
