using CorujasDev.Identity.Dominio.Interfaces.Repositorios;
using CorujasDev.Identity.Infra.Data.Contexto;
using CorujasDev.Identity.Infra.Data.Repositorios;
using CorujasDev.Identity.Servicos.Interfaces;
using CorujasDev.Identity.Servicos.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace CorujasDev.Identity.Servicos.Ioc
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IUsuarioServico, UsuarioServico>();
            services.AddSingleton<IUsuarioRepositorio, UsuarioRepositorio>();

            services.AddScoped<UsuariosContexto>();
        }
    }
}
