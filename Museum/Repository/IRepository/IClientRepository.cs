using Museum.Models;

namespace Museum.Repository.IRepository
{
    public interface IClientRepository : IRepository<Client>
    {
        Task<Client> Update(Client entity);
    }
   
}
