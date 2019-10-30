using CorujasDev.Eventos.Dominio.Interfaces.Repositorios;
using CorujasDev.Eventos.Infra.Data.Contexto;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace CorujasDev.Eventos.Infra.Data.Repositorios
{
    public abstract class BaseRepositorio<T> : IBaseRepositorio<T> where T : class
    {
        private EventosContexto _contexto;

        public BaseRepositorio()
        {
            _contexto = new EventosContexto();
        }

        public void Alterar(T Objeto)
        {
            _contexto.Entry<T>(Objeto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public T BuscarPorId(Guid id)
        {
            return _contexto.Find<T>(id);
        }

        public void Commit()
        {
            _contexto.SaveChanges();
        }

        public void Dispose()
        {
            if (_contexto != null)
            {
                _contexto.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public void Inserir(T Objeto)
        {
            _contexto.Add<T>(Objeto);
        }

        public IQueryable<T> Listar()
        {
            return _contexto.Set<T>().AsQueryable();
        }

        public IQueryable<T> Pesquisar(Expression<Func<T, bool>> filtro)
        {
            return _contexto.Set<T>().Where(filtro);
        }
    }
}
