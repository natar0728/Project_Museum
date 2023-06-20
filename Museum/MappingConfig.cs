using AutoMapper;
using Museum.Models;
using Museum.Models.Dto;

namespace Museum
{
    public class MappingConfig : Profile
    {
        //LUEGO HACER LOS MAPS DE LOS CREATE Y UPDATE
        public MappingConfig()
        {
        //Autor---------------------------
            CreateMap<Autor, AutorDto>().ReverseMap();
            CreateMap<Autor, AutorCreateDto>().ReverseMap();
            CreateMap<Autor, AutorUpdateDto>().ReverseMap();

            //Obra---------------------------
            CreateMap<Obra, ObraDto>().ReverseMap();
            CreateMap<Obra, ObraCreateDto>().ReverseMap();
            CreateMap<Obra, ObraUpdateDto>().ReverseMap();

            //Expo---------------------------
            CreateMap<Exposicion, ExposicionDto>().ReverseMap();
            CreateMap<Exposicion, ExposicionCreateDto>().ReverseMap();
            CreateMap<Exposicion, ExposicionUpdateDto>().ReverseMap();

            //Client-------------------------
            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<Client, ClientCreateDto>().ReverseMap();
            CreateMap<Client, ClientUpdateDto>().ReverseMap();

            //Ticket-------------------------
            CreateMap<Ticket, TicketDto>().ReverseMap();
            CreateMap<Ticket, TicketCreateDto>().ReverseMap();
            CreateMap<Ticket, TicketUpdateDto>().ReverseMap();

        }
    }
}
