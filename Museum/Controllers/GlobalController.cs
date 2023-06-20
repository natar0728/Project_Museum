using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Museum.Data;
using Museum.Models;

namespace Museum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GlobalController : ControllerBase
    {
        private readonly MuseumContext _db;
        private readonly ILogger<GlobalController> _logger;
        private readonly IMapper _mapper;

        public GlobalController(MuseumContext context, ILogger<GlobalController> logger, IMapper mapper)
        {
            _db = context;
            _logger=logger;
            _mapper=mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Obra>>> GetObrasAutor(int autID)
        {


            //Obra obra1 = new Obra();
            //obra1.Titulo = "Op Laikao";
            //obra1.Descripcion = "Mucho Texto---";
            //obra1.Tipo = "Escultura";

            //var autor = _context.Autores.FirstOrDefault(x => x.IdAutor ==autID);

            //if ( autor == null)
            //{
            //    return NotFound();
            //}
            //obra1.Author = autor;

            //_context.Obras.Add(obra1);


            //await _context.SaveChangesAsync();

            var ObrasdeAut = await _db.Obras.Include(o => o.Author).Where(o => o.Author.Id == autID).ToListAsync();
            return ObrasdeAut;
        }

        [HttpGet("PostObraDetails/")]
        public async Task<ActionResult<Obra>> GetObra(int ID)
        {



            //var Aut = await _context.Autores.Where(a => a.Id == autID).Include(a => a.AuthorObras).
            //    FirstOrDefaultAsync();

            //if (Aut == null)
            //{
            //    return NotFound();
            //}

            _logger.LogInformation("Obtener una obra");

            //EL INCLUDE SOLO FUNCA SI EN EL DTO ESTA 'Author' xd
            var obra = await _db.Obras/*.Include(a => a.Author)*/.Where(o => o.Id == ID).FirstOrDefaultAsync();
            var rest = _mapper.Map<Obra>(obra);

            return Ok(rest);
        }


        [HttpGet("PostAutorDetails/")]
        public async Task<ActionResult<Autor>> GetAutor(int autID)
        {
            


            var Aut = await _db.Autores.Where(a => a.Id == autID).Include(a => a.AuthorObras).
                FirstOrDefaultAsync();

            if (Aut == null)
            {
                return NotFound();
            }


            return Aut;
        }


        [HttpGet("PostExpoDetails/")]
        public async Task<ActionResult<Exposicion>> PostExposDetails()
        {
            if (_db.Exposiciones == null)
            {
                return Problem("Entity set 'MuseumContext.Autores'  is null.");
            }



            var espos = await _db.Exposiciones.Include(exp => exp.Author).
                ThenInclude(a => a.AuthorObras).
                Where(e => e.Author.Id == 1).
                FirstOrDefaultAsync();


            if (espos== null)
            {
                return NotFound();
            }
            return espos;
            /*  return CreatedAtAction("GetAutor", new { id = autor.IdAutor }, autor)*/
            ;
        }

    }
}
