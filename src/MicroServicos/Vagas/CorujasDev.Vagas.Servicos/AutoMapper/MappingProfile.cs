using AutoMapper;
using  CorujasDev.Vagas.Dominio.Entidades;
using  CorujasDev.Vagas.Servicos.ViewModels.Vaga;

namespace CorujasDev.Vagas.Servicos.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<VagaEntidade, VagaViewModel>();

            CreateMap<VagaViewModel, VagaEntidade>();
        }
    }
}
