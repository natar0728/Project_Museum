using Museum.Data;
using Museum.Models;
using Museum.Repository.IRepository;

namespace Museum.Repository
{
    public class AutorRepository : Repository<Autor>, IAutorRepository
    {
        private readonly MuseumContext _db;

        public AutorRepository(MuseumContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Autor> Update(Autor entity)
        {
            _db.Autores.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
