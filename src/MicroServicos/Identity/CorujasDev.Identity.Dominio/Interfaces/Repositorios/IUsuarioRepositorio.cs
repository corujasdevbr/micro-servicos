using System;
using System.Linq;
using System.Linq.Expressions;
using CorujasDev.Identity.Dominio.Entidades;

namespace CorujasDev.Identity.Dominio.Interfaces.Repositorios
{
    public interface IUsuarioRepositorio
    {
        IQueryable<UsuarioEntidade> Listar();

        UsuarioEntidade BuscarPorId(Guid id);

        void Inserir(UsuarioEntidade vaga);

        void Alterar(UsuarioEntidade vaga);

        IQueryable<UsuarioEntidade> Pesquisar(Expression<Func<UsuarioEntidade, bool>> predicate);

        void Commit();

        void Dispose();
    }
}