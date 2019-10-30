using System;
using System.Linq;
using System.Linq.Expressions;
using  CorujasDev.Vagas.Dominio.Entidades;
using  CorujasDev.Vagas.Dominio.Interfaces.Repositorios;
using  CorujasDev.Vagas.Infra.Data.Contexto;

namespace CorujasDev.Vagas.Infra.Data.Repositorios
{
    public class VagaRepositorio : IVagaRepositorio
    {
        private VagasContexto _contexto;

        public VagaRepositorio()
        {
            _contexto = new VagasContexto();
        }

        public void Alterar(VagaEntidade vaga)
        {
            _contexto.Entry<VagaEntidade>(vaga).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public VagaEntidade BuscarPorId(Guid id)
        {
            return _contexto.Vagas.Find(id);
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

        public void Inserir(VagaEntidade vaga)
        {
            _contexto.Vagas.Add(vaga);
        }

        public IQueryable<VagaEntidade> Listar()
        {
            return _contexto.Vagas;
        }

        public IQueryable<VagaEntidade> Pesquisar(Expression<Func<VagaEntidade, bool>> filtro)
        {
            return _contexto.Set<VagaEntidade>().Where(filtro);
        }
    }
}
