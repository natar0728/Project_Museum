using Museum.Data;
using Museum.Models;
using Museum.Repository.IRepository;

namespace Museum.Repository
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        private readonly MuseumContext _db;

        public TicketRepository(MuseumContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Ticket> Update(Ticket entity)
        {
            _db.Tickets.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
