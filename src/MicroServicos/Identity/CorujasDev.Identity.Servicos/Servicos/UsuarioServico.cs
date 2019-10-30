using System;
using System.Linq.Expressions;
using AutoMapper;
using CorujasDev.Identity.Dominio.Entidades;
using CorujasDev.Identity.Dominio.Interfaces.Repositorios;
using CorujasDev.Identity.Servicos.Interfaces;
using CorujasDev.Identity.Servicos.ViewModels.Login;
using CorujasDev.Identity.Servicos.ViewModels.Usuario;

namespace CorujasDev.Identity.Servicos.Servicos
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioRepositorio _usuarioRepositorio;


        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio, IMapper mapper)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _mapper = mapper;
        }

        public void Alterar(UsuarioViewModel usuario)
        {
            var usuarioRetorna = _mapper.Map<UsuarioViewModel>(_usuarioRepositorio.BuscarPorId(usuario.Id));

            if (usuarioRetorna == null)
                throw new Exception("Id não encontrada");

            _usuarioRepositorio.Alterar(_mapper.Map<UsuarioEntidade>(usuario));
        }

        public void Ativar(Guid id)
        {
            throw new NotImplementedException();
        }

        public UsuarioViewModel Autenticar(LoginViewModel login)
        {
            throw new NotImplementedException();
        }

        public UsuarioViewModel BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Desativar(Guid id)
        {
            throw new NotImplementedException();
        }

        public UsuarioHomeViewModel Filtrar(Expression<Func<UsuarioEntidade, bool>> filtro)
        {
            throw new NotImplementedException();
        }

        public void Inserir(UsuarioViewModel Usuario)
        {
            throw new NotImplementedException();
        }

        public UsuarioHomeViewModel Listar()
        {
            throw new NotImplementedException();
        }
    }
}
