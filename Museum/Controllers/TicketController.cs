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
    public class TicketController : ControllerBase
    {
        private readonly ILogger<TicketController> _logger;
        private readonly ITicketRepository _ticketRepo;
        private readonly IMapper _mapper;
        public TicketController(ILogger<TicketController> logger, ITicketRepository ticketRepo, IMapper mapper)
        {
            _logger = logger;
            _ticketRepo = ticketRepo;
            _mapper = mapper;
        }

        // GET: api/Ticket
        //[HttpGet]
        //    public async Task<ActionResult<IEnumerable<Ticket>>> GetTicketes()
        //    {
        //        if (_context.Ticketes == null)
        //        {
        //            return NotFound();
        //        }
        //        return await _context.Ticketes.Include(au => au.AuthorObras).ToListAsync();
        //    }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<TicketDto>>> GetTicket()
        {
            _logger.LogInformation("Obtener los Tickets");

            var TicketList = await _ticketRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<TicketDto>>(TicketList));
        }

        // GET: api/Ticket/5
        [HttpGet("{id:int}", Name = "GetTicket")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TicketDto>> GetTicket(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Ticket con Id {id}");
                return BadRequest();
            }
            var tickt = await _ticketRepo.Get(a => a.Id == id);

            if (tickt == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<TicketDto>(tickt));
        }

        // PUT: api/Ticket/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateTicket(int id, [FromBody] TicketUpdateDto TicketUpdateDto)
        {
            if (TicketUpdateDto == null || id != TicketUpdateDto.Id)
            {
                return BadRequest();
            }

            Ticket modelo = _mapper.Map<Ticket>(TicketUpdateDto);

            //Ticket modelo = new()
            //{
            //    TicketId = TicketUpdateDto.TicketId,
            //    TicketName = TicketUpdateDto.TicketName
            //};

            await _ticketRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialTicket(int id, JsonPatchDocument<TicketUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Ticket = await _ticketRepo.Get(s => s.Id == id, tracked: false);

            TicketUpdateDto TicketUpdateDto = _mapper.Map<TicketUpdateDto>(Ticket);
           
            if (Ticket == null) return BadRequest();

            patchDto.ApplyTo(TicketUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Ticket modelo = _mapper.Map<Ticket>(TicketUpdateDto);
            
            await _ticketRepo.Update(modelo);

            return NoContent();
        }

        // POST: api/Ticket
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TicketDto>> AddStudent([FromBody] TicketCreateDto ticketCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           

            if (ticketCreateDto == null)
            {
                return BadRequest(ticketCreateDto);
            }

            Ticket modelo = _mapper.Map<Ticket>(ticketCreateDto);

            //Student modelo = new()
            //{
            //    StudentName = TicketCreateDto.StudentName
            //};

            await _ticketRepo.Add(modelo);

            return CreatedAtRoute("GetTicket", new { id = modelo.Id }, modelo);


        }



        // DELETE: api/Ticket/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var tickt = await _ticketRepo.Get(a => a.Id == id);

            if (tickt == null)
            {
                return NotFound();
            }

            await _ticketRepo.Remove(tickt);

            return NoContent();
        }


    }
}
