using AutoMapper;
using Senai.Alunos.Vagas.Dominio.Entidades;
using Senai.Alunos.Vagas.Servicos.ViewModels.Vaga;

namespace Senai.Alunos.Vagas.Servicos.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {

            CreateMap<VagaEntidade, VagaViewModel>();
        }
    }
}
