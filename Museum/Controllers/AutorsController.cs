using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Museum.Data;
using Museum.Models;
using Museum.Models.Dto;
using Museum.Repository.IRepository;

namespace Museum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorsController : ControllerBase
    {
        private readonly ILogger<AutorsController> _logger;
        private readonly IAutorRepository _autorRepo;
        private readonly IMapper _mapper;
        public AutorsController(ILogger<AutorsController> logger, IAutorRepository autorRepo, IMapper mapper)
        {
            _logger = logger;
            _autorRepo = autorRepo;
            _mapper = mapper;
        }

        

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<AutorDto>>> GetAutors()
        {
            _logger.LogInformation("Obtener los Estudiantes");

            var AutorList = await _autorRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<AutorDto>>(AutorList));
        }

        // GET: api/Autors/5
        [HttpGet("{id:int}", Name = "GetAutor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<AutorDto>> GetAutor(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Estudiante con Id {id}");
                return BadRequest();
            }
            var aut = await _autorRepo.Get(a => a.Id == id);

            if (aut == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AutorDto>(aut));
        }

        // PUT: api/Autors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateAutor(int id, [FromBody] AutorUpdateDto AutorUpdateDto)
        {
            if (AutorUpdateDto == null || id != AutorUpdateDto.Id)
            {
                return BadRequest();
            }

            Autor modelo = _mapper.Map<Autor>(AutorUpdateDto);

            //Autor modelo = new()
            //{
            //    AutorId = AutorUpdateDto.AutorId,
            //    AutorName = AutorUpdateDto.AutorName
            //};

            await _autorRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialAutor(int id, JsonPatchDocument<AutorUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Autor = await _autorRepo.Get(s => s.Id == id, tracked: false);

            AutorUpdateDto AutorUpdateDto = _mapper.Map<AutorUpdateDto>(Autor);
            //AutorUpdateDto AutorUpdateDto = new()
            //{
            //    AutorId = Autor.AutorId,
            //    AutorName = Autor.AutorName
            //};
            if (Autor == null) return BadRequest();

            patchDto.ApplyTo(AutorUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Autor modelo = _mapper.Map<Autor>(AutorUpdateDto);
            //Autor modelo = new()
            //{
            //    AutorId = AutorUpdateDto.AutorId,
            //    AutorName = AutorUpdateDto.AutorName
            //};
            await _autorRepo.Update(modelo);

            return NoContent();
        }

        // POST: api/Autors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<AutorDto>> AddStudent([FromBody] AutorCreateDto autorCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //if (await _autorRepo.Get(s => s.StudentName.ToLower() == AutorCreateDto.StudentName.ToLower()) != null)
            //{
            //    ModelState.AddModelError("NombreExiste", "¡El Estudiante con ese Nombre ya existe!");
            //    return BadRequest(ModelState);
            //}


            if (autorCreateDto == null)
            {
                return BadRequest(autorCreateDto);
            }

            Autor modelo = _mapper.Map<Autor>(autorCreateDto);

            //Student modelo = new()
            //{
            //    StudentName = AutorCreateDto.StudentName
            //};

            await _autorRepo.Add(modelo);

            return CreatedAtRoute("GetAutor", new { id = modelo.Id }, modelo);


        }


        //********************************************************************************************************************************
        //ESTO SOLO ES PRUEBASSSSSSS---------------------------------------------------------------------------------//

        //********************************************************************************************************************************



        // DELETE: api/Autors/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteAutor(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var aut = await _autorRepo.Get(a => a.Id == id);

            if (aut == null)
            {
                return NotFound();
            }

            await _autorRepo.Remove(aut);

            return NoContent();
        }

        //private bool AutorExists(int id)
        //{
        //    return (_context.Autores?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
