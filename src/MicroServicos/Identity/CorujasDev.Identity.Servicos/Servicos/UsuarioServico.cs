using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using AutoMapper;
using CorujasDev.Identity.Dominio.Entidades;
using CorujasDev.Identity.Dominio.Enums;
using CorujasDev.Identity.Dominio.Interfaces.Repositorios;
using CorujasDev.Identity.Servicos.Interfaces;
using CorujasDev.Identity.Servicos.ViewModels.Login;
using CorujasDev.Identity.Servicos.ViewModels.Usuario;
using Microsoft.IdentityModel.Tokens;

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
            try
            {
                var Usuario = _mapper.Map<UsuarioViewModel>(_usuarioRepositorio.BuscarPorId(id));

                if (Usuario == null)
                    throw new Exception("Id não encontrada");

                Usuario.Ativo = true;
                _usuarioRepositorio.Alterar(_mapper.Map<UsuarioEntidade>(Usuario));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Autenticar(LoginViewModel login)
        {
            try
            {
                var usuario = _usuarioRepositorio.Pesquisar(x => x.Email.ToLower() == login.Email.ToLower() && x.Senha == login.Password);
                
                if (usuario.Count == 0)
                    return null;

                UsuarioViewModel usuarioBuscado = _mapper.Map<UsuarioViewModel>(usuario.FirstOrDefault());

                // informacoes referentes ao usuario
                var claims = new[]
               {
                    // email
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
                    // id
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.Id.ToString()),
                    // permissao
                    new Claim(ClaimTypes.Role,   Enum.GetName(typeof(EnumTipoUsuario), usuarioBuscado.TipoUsuario)),
                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("corujasdev-chave-autenticacao"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "CorujasDev.WebApi",
                    audience: "CorujasDev.WebApi",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds);

                return new JwtSecurityTokenHandler().WriteToken(token);
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public UsuarioViewModel BuscarPorId(Guid id)
        {
            try
            {
                return _mapper.Map<UsuarioViewModel>(_usuarioRepositorio.BuscarPorId(id));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Desativar(Guid id)
        {
            try
            {
                var Usuario = _mapper.Map<UsuarioViewModel>(_usuarioRepositorio.BuscarPorId(id));

                if (Usuario == null)
                    throw new Exception("Id não encontrada");

                Usuario.Ativo = false;
                _usuarioRepositorio.Alterar(_mapper.Map<UsuarioEntidade>(Usuario));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public UsuarioHomeViewModel Filtrar(Expression<Func<UsuarioEntidade, bool>> filtro)
        {
            try
            {
                UsuarioHomeViewModel viewModel = new UsuarioHomeViewModel();
                viewModel.Usuarios = _mapper.Map<List<UsuarioViewModel>>(_usuarioRepositorio.Pesquisar(filtro));
                viewModel.quantidade = viewModel.Usuarios.Count;

                return viewModel;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Inserir(UsuarioViewModel Usuario)
        {
            try
            {
                _usuarioRepositorio.Inserir(_mapper.Map<UsuarioEntidade>(Usuario));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public UsuarioHomeViewModel Listar()
        {
            try
            {
                UsuarioHomeViewModel viewModel = new UsuarioHomeViewModel();
                viewModel.Usuarios = _mapper.Map<List<UsuarioViewModel>>(_usuarioRepositorio.Listar());
                viewModel.quantidade = viewModel.Usuarios.Count;

                return viewModel;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
