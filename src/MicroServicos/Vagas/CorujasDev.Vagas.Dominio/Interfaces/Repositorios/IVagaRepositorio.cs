using System;
using System.Linq;
using System.Linq.Expressions;
using  CorujasDev.Vagas.Dominio.Entidades;

namespace CorujasDev.Vagas.Dominio.Interfaces.Repositorios
{
    public interface IVagaRepositorio
    {
        IQueryable<VagaEntidade> Listar();

        VagaEntidade BuscarPorId(Guid id);

        void Inserir(VagaEntidade vaga);

        void Alterar(VagaEntidade vaga);

        IQueryable<VagaEntidade> Pesquisar(Expression<Func<VagaEntidade, bool>> predicate);

        void Commit();

        void Dispose();
    }
}
