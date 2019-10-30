using AutoMapper;
using CorujasDev.Eventos.Dominio.Entidades;
using CorujasDev.Eventos.Servicos.ViewModels.Evento;

namespace CorujasDev.Eventos.Servicos.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EventoEntidade, EventoViewModel>();

            CreateMap<EventoViewModel, EventoEntidade>();
        }
    }
}
