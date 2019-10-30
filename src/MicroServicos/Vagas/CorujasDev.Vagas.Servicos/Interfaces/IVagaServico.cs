using System;
using System.Linq.Expressions;
using  CorujasDev.Vagas.Dominio.Entidades;
using  CorujasDev.Vagas.Servicos.ViewModels.Vaga;

namespace CorujasDev.Vagas.Servicos.Interfaces
{
    public interface IVagaServico
    {
        VagaHomeViewModel Listar();

        VagaViewModel BuscarPorId(Guid id);

        VagaHomeViewModel Filtrar(Expression<Func<VagaEntidade, bool>> filtro);

        void Inserir(VagaViewModel vaga);

        void Alterar(VagaViewModel vaga);

        void Ativar(Guid id);

        void Desativar(Guid id);
    }
}
