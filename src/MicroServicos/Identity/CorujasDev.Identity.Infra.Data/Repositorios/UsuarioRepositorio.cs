using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CorujasDev.Identity.Dominio.Entidades;
using CorujasDev.Identity.Dominio.Interfaces.Repositorios;
using CorujasDev.Identity.Infra.Data.Contexto;

namespace CorujasDev.Identity.Infra.Data.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private UsuariosContexto _contexto;

        public UsuarioRepositorio()
        {
            _contexto = new UsuariosContexto();
        }

        public void Alterar(UsuarioEntidade Usuario)
        {
            _contexto.Entry<UsuarioEntidade>(Usuario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public UsuarioEntidade BuscarPorId(Guid id)
        {
            return _contexto.Usuarios.Find(id);
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

        public void Inserir(UsuarioEntidade Usuario)
        {
            _contexto.Usuarios.Add(Usuario);
        }

        public IQueryable<UsuarioEntidade> Listar()
        {
            return _contexto.Usuarios;
        }

        public ICollection<UsuarioEntidade> Pesquisar(Expression<Func<UsuarioEntidade, bool>> filtro)
        {
            return _contexto.Usuarios.Where(filtro).ToList();
        }
    }
}

