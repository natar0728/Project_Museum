using Museum.Data;
using Museum.Models;
using Museum.Repository.IRepository;

namespace Museum.Repository
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        private readonly MuseumContext _db;

        public ClientRepository(MuseumContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Client> Update(Client entity)
        {
            _db.Clientes.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
