using System;
using System.Linq;
using System.Linq.Expressions;

namespace CorujasDev.Eventos.Dominio.Interfaces.Repositorios
{
    public interface IBaseRepositorio<T> where T : class
    {
        IQueryable<T> Listar();

        T BuscarPorId(Guid id);

        void Inserir(T Objeto);

        void Alterar(T Objeto);

        IQueryable<T> Pesquisar(Expression<Func<T, bool>> filtro);

        void Commit();

        void Dispose();
    }
}
