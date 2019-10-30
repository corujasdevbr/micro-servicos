using System;
using System.Linq.Expressions;
using CorujasDev.Identity.Dominio.Entidades;
using CorujasDev.Identity.Servicos.ViewModels.Login;
using CorujasDev.Identity.Servicos.ViewModels.Usuario;

namespace CorujasDev.Identity.Servicos.Interfaces
{
    public interface IUsuarioServico
    {
        UsuarioHomeViewModel Listar();

        UsuarioViewModel BuscarPorId(Guid id);

        UsuarioHomeViewModel Filtrar(Expression<Func<UsuarioEntidade, bool>> filtro);

        void Inserir(UsuarioViewModel Usuario);

        void Alterar(UsuarioViewModel Usuario);

        void Ativar(Guid id);

        void Desativar(Guid id);

        UsuarioViewModel Autenticar(LoginViewModel login);
    }
}
