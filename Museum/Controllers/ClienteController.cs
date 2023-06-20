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
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly IClientRepository _clientRepo;
        private readonly IMapper _mapper;
        public ClienteController(ILogger<ClienteController> logger, IClientRepository clientRepo, IMapper mapper)
        {
            _logger = logger;
            _clientRepo = clientRepo;
            _mapper = mapper;
        }

        // GET: api/Cliente
        //[HttpGet]
        //    public async Task<ActionResult<IEnumerable<Client>>> GetClientes()
        //    {
        //        if (_context.Clientes == null)
        //        {
        //            return NotFound();
        //        }
        //        return await _context.Clientes.Include(au => au.AuthorObras).ToListAsync();
        //    }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ClientDto>>> GetClientes()
        {
            _logger.LogInformation("Obtener los Clientes");

            var ClientsList = await _clientRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<ClientDto>>(ClientsList));
        }

        // GET: api/Cliente/5
        [HttpGet("{id:int}", Name = "GetCliente")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ClientDto>> GetClient(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Cliente con Id {id}");
                return BadRequest();
            }
            var cl = await _clientRepo.Get(a => a.Id == id);

            if (cl == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ClientDto>(cl));
        }

        // PUT: api/Cliente/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateClient(int id, [FromBody] ClientUpdateDto ClientUpdateDto)
        {
            if (ClientUpdateDto == null || id != ClientUpdateDto.Id)
            {
                return BadRequest();
            }

            Client modelo = _mapper.Map<Client>(ClientUpdateDto);

            

            await _clientRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialClient(int id, JsonPatchDocument<ClientUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Client = await _clientRepo.Get(c => c.Id == id, tracked: false);

            ClientUpdateDto ClientUpdateDto = _mapper.Map<ClientUpdateDto>(Client);
            

            if (Client == null) return BadRequest();

            patchDto.ApplyTo(ClientUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Client modelo = _mapper.Map<Client>(ClientUpdateDto);
          
            await _clientRepo.Update(modelo);

            return NoContent();
        }

        // POST: api/Cliente
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ClientDto>> AddCliente([FromBody] ClientCreateDto clientCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

          


            if (clientCreateDto == null)
            {
                return BadRequest(clientCreateDto);
            }

            Client modelo = _mapper.Map<Client>(clientCreateDto);

           

            await _clientRepo.Add(modelo);

            return CreatedAtRoute("GetCliente", new { id = modelo.Id }, modelo);


        }


        //********************************************************************************************************************************
        //ESTO SOLO ES PRUEBASSSSSSS---------------------------------------------------------------------------------//

        //********************************************************************************************************************************



        // DELETE: api/Cliente/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteClient(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var cl = await _clientRepo.Get(a => a.Id == id);

            if (cl == null)
            {
                return NotFound();
            }

            await _clientRepo.Remove(cl);

            return NoContent();
        }
    }
}
