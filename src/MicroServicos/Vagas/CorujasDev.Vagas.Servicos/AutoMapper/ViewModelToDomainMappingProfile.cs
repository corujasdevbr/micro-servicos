using System;
using AutoMapper;
using Senai.Alunos.Vagas.Dominio.Entidades;
using Senai.Alunos.Vagas.Servicos.ViewModels.Vaga;

namespace Senai.Alunos.Vagas.Servicos.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<VagaViewModel, VagaEntidade>();
        }
    }
}
