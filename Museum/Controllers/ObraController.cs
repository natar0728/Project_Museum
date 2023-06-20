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
    public class ObraController : ControllerBase
    {
        private readonly ILogger<ObraController> _logger;
        private readonly IObraRepository _obraRepo;
        private readonly IMapper _mapper;
        public ObraController(ILogger<ObraController> logger, IObraRepository obraRepo, IMapper mapper)
        {
            _logger = logger;
            _obraRepo = obraRepo;
            _mapper = mapper;
        }

       
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ObraDto>>> GetObras()
        {
            _logger.LogInformation("Obtener las Obras");

            var ObraList = await _obraRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<ObraDto>>(ObraList));
        }

        // GET: api/Obra/5
        [HttpGet("{id:int}", Name = "GetObra")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ObraDto>> GetObra(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Obra con Id {id}");
                return BadRequest();
            }
            var obr = await _obraRepo.Get(a => a.Id == id);

            if (obr == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ObraDto>(obr));
        }

        // PUT: api/Obra/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateObra(int id, [FromBody] ObraUpdateDto ObraUpdateDto)
        {
            if (ObraUpdateDto == null || id != ObraUpdateDto.Id)
            {
                return BadRequest();
            }

            Obra modelo = _mapper.Map<Obra>(ObraUpdateDto);

            //Obra modelo = new()
            //{
            //    ObraId = ObraUpdateDto.ObraId,
            //    ObraName = ObraUpdateDto.ObraName
            //};

            await _obraRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialObra(int id, JsonPatchDocument<ObraUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Obra = await _obraRepo.Get(s => s.Id == id, tracked: false);

            ObraUpdateDto ObraUpdateDto = _mapper.Map<ObraUpdateDto>(Obra);
            //ObraUpdateDto ObraUpdateDto = new()
            //{
            //    ObraId = Obra.ObraId,
            //    ObraName = Obra.ObraName
            //};
            if (Obra == null) return BadRequest();

            patchDto.ApplyTo(ObraUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Obra modelo = _mapper.Map<Obra>(ObraUpdateDto);
            //Obra modelo = new()
            //{
            //    ObraId = ObraUpdateDto.ObraId,
            //    ObraName = ObraUpdateDto.ObraName
            //};
            await _obraRepo.Update(modelo);

            return NoContent();
        }

        // POST: api/Obra
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ObraDto>> AddStudent([FromBody] ObraCreateDto obraCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           

            if (obraCreateDto == null)
            {
                return BadRequest(obraCreateDto);
            }

            Obra modelo = _mapper.Map<Obra>(obraCreateDto);

            //Student modelo = new()
            //{
            //    StudentName = ObraCreateDto.StudentName
            //};

            await _obraRepo.Add(modelo);

            return CreatedAtRoute("GetObra", new { id = modelo.Id }, modelo);


        }


        //********************************************************************************************************************************
        //ESTO SOLO ES PRUEBASSSSSSS---------------------------------------------------------------------------------//

        //********************************************************************************************************************************



        // DELETE: api/Obra/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteObra(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var obr = await _obraRepo.Get(a => a.Id == id);

            if (obr == null)
            {
                return NotFound();
            }

            await _obraRepo.Remove(obr);

            return NoContent();
        }

    }
}
