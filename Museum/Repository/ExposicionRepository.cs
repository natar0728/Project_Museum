using Museum.Data;
using Museum.Models;
using Museum.Repository.IRepository;

namespace Museum.Repository
{
    public class ExposicionRepository : Repository<Exposicion>, IExposicionRepository
    {
        private readonly MuseumContext _db;

        public ExposicionRepository(MuseumContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Exposicion> Update(Exposicion entity)
        {
            _db.Exposiciones.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
