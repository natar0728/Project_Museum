using Museum.Models;

namespace Museum.Repository.IRepository
{
    public interface IAutorRepository:IRepository<Autor>
    {
        Task<Autor> Update(Autor entity);
    }
}
