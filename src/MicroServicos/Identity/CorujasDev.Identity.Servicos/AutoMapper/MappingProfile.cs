using AutoMapper;
using CorujasDev.Identity.Dominio.Entidades;
using CorujasDev.Identity.Servicos.ViewModels.Usuario;

namespace CorujasDev.Identity.Servicos.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UsuarioEntidade, UsuarioViewModel>()
                    .ReverseMap();

            CreateMap<UsuarioEntidade, CadastrarUsuarioViewModel>()
                    .ReverseMap();
        }
    }
}
