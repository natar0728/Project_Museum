using Museum.Data;
using Museum.Models;
using Museum.Repository.IRepository;

namespace Museum.Repository
{
    public class ObraRepository : Repository<Obra>, IObraRepository
    {
        private readonly MuseumContext _db;

        public ObraRepository(MuseumContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Obra> Update(Obra entity)
        {
            _db.Obras.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
