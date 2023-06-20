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
    public class ExposicionController : ControllerBase
    {
        private readonly ILogger<ExposicionController> _logger;
        private readonly IExposicionRepository _expoRepo;
        private readonly IMapper _mapper;
        public ExposicionController(ILogger<ExposicionController> logger, IExposicionRepository expoRepo, IMapper mapper)
        {
            _logger = logger;
            _expoRepo = expoRepo;
            _mapper = mapper;
        }

       

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ExposicionDto>>> GetExposiciones()
        {
            _logger.LogInformation("Obtener las Exposiciones");

            var ExposicionList = await _expoRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<ExposicionDto>>(ExposicionList));
        }

        // GET: api/Exposicion/5
        [HttpGet("{id:int}", Name = "GetExposicion")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ExposicionDto>> GetExposicion(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer expopsicion con Id {id}");
                return BadRequest();
            }
            var exp = await _expoRepo.Get(a => a.Id == id);

            if (exp == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ExposicionDto>(exp));
        }

        // PUT: api/Exposicion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateExposicion(int id, [FromBody] ExposicionUpdateDto ExposicionUpdateDto)
        {
            if (ExposicionUpdateDto == null || id != ExposicionUpdateDto.Id)
            {
                return BadRequest();
            }

            Exposicion modelo = _mapper.Map<Exposicion>(ExposicionUpdateDto);

            //Exposicion modelo = new()
            //{
            //    ExposicionId = ExposicionUpdateDto.ExposicionId,
            //    ExposicionName = ExposicionUpdateDto.ExposicionName
            //};

            await _expoRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialExposicion(int id, JsonPatchDocument<ExposicionUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Exposicion = await _expoRepo.Get(s => s.Id == id, tracked: false);

            ExposicionUpdateDto ExposicionUpdateDto = _mapper.Map<ExposicionUpdateDto>(Exposicion);
            //ExposicionUpdateDto ExposicionUpdateDto = new()
            //{
            //    ExposicionId = Exposicion.ExposicionId,
            //    ExposicionName = Exposicion.ExposicionName
            //};
            if (Exposicion == null) return BadRequest();

            patchDto.ApplyTo(ExposicionUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Exposicion modelo = _mapper.Map<Exposicion>(ExposicionUpdateDto);
           
            await _expoRepo.Update(modelo);

            return NoContent();
        }

        // POST: api/Exposicion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ExposicionDto>> AddStudent([FromBody] ExposicionCreateDto expoCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //if (await _expoRepo.Get(s => s.StudentName.ToLower() == ExposicionCreateDto.StudentName.ToLower()) != null)
            //{
            //    ModelState.AddModelError("NombreExiste", "¡El Estudiante con ese Nombre ya existe!");
            //    return BadRequest(ModelState);
            //}


            if (expoCreateDto == null)
            {
                return BadRequest(expoCreateDto);
            }

            Exposicion modelo = _mapper.Map<Exposicion>(expoCreateDto);

            //Student modelo = new()
            //{
            //    StudentName = ExposicionCreateDto.StudentName
            //};

            await _expoRepo.Add(modelo);

            return CreatedAtRoute("GetExposicion", new { id = modelo.Id }, modelo);


        }


      

        // DELETE: api/Exposicion/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteExposicion(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var exp = await _expoRepo.Get(a => a.Id == id);

            if (exp == null)
            {
                return NotFound();
            }

            await _expoRepo.Remove(exp);

            return NoContent();
        }


    }
}
