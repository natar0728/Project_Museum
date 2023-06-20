using Museum.Models;

namespace Museum.Repository.IRepository
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        Task<Ticket> Update(Ticket entity);
    }
}
